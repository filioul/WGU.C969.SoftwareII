using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WGU.C969.SoftwareII.Tools
{
    public class Appointment
    {
        public static void AddAppointment(DateTime start, DateTime end, string givenUser, string customerName, string location, string contact, string type, string url, string title, string desc, string user)
        {
            DateTime startEST = ConvertToEST(start);
            DateTime endEST = ConvertToEST(end);
            int customerID = Customer.GetCustomerID(customerName);
            int userID = GetUserID(givenUser);
            title = ChangeValueIfEmpty(title);
            desc = ChangeValueIfEmpty(desc);
            location = ChangeValueIfEmpty(location);
            contact = ChangeValueIfEmpty(contact);
            url = ChangeValueIfEmpty(url);
            try
            {
                string sql = $"INSERT INTO appointment VALUES (NULL, @customerId, @userId, @title, @desc, @location, @contact, @type, @url, @start, @end, NOW(), @user, NOW(), @user)";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                cmd.Parameters.AddWithValue("@userId", userID);
                cmd.Parameters.AddWithValue("@customerId", customerID);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@url", url);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@start", startEST);
                cmd.Parameters.AddWithValue("@end", endEST);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error thrown while creating appointment: " + ex);
            }

        }

        public static void UpdateAppointment(DateTime start, DateTime end, string givenUser, string customerName, string location, string contact, string type, string url, string title, string desc, string user, string appointmentID, string originalUser)
        {

            int numericalID = int.Parse(appointmentID);
            DateTime startEST = ConvertToEST(start);
            DateTime endEST = ConvertToEST(end);
            int availability;
            if (!DataValidation.ValidateText(givenUser))
            {
                availability = CheckAvailabilityReturnCount(startEST, endEST, originalUser, numericalID);
            } else
            {
                availability = CheckAvailabilityReturnCount(startEST, endEST, givenUser, numericalID);
            }

            if (availability == 0)
            {
                UpdateAppointmentStartEnd(startEST, endEST, user, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);

            }
            else
            {
                MessageBox.Show("That time slot is not available, please try again.");
                return;
            }


        }

        internal static bool CheckAvailability(DateTime start, DateTime end, string user)
        {
            bool result = true;
            DateTime startEST = ConvertToEST(start);
            DateTime endEST = ConvertToEST(end);
            string startSQL = FormatDateTimeForSQL(startEST);
            string endSQL = FormatDateTimeForSQL(endEST);
            int userID = GetUserID(user);
            try
            {
                string sql = $"SELECT * FROM appointment WHERE userId = {userID} AND (('{startSQL}' BETWEEN start AND end) OR ('{endSQL}' BETWEEN start AND end))";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }
            return result;
        }



        internal static bool CheckBusinessHours(DateTime start, DateTime end)
        {
            bool result = false;
            try
            {
                DateTime startEST = ConvertToEST(start);
                DateTime endEST = ConvertToEST(end);
                if (startEST.TimeOfDay < endEST.TimeOfDay)
                {
                    if (startEST.DayOfWeek == endEST.DayOfWeek
                        && (startEST.DayOfWeek != DayOfWeek.Sunday || startEST.DayOfWeek != DayOfWeek.Saturday))
                    {
                        DateTime workdayStart = new DateTime(2000, 01, 01, 9, 0, 0);
                        DateTime workdayEnd = new DateTime(2000, 01, 01, 17, 0, 0, 0);
                        if ((startEST.TimeOfDay >= workdayStart.TimeOfDay && startEST.TimeOfDay <= workdayEnd.TimeOfDay) && (endEST.TimeOfDay >= workdayStart.TimeOfDay && endEST.TimeOfDay <= workdayEnd.TimeOfDay))
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown when checking business hours: " + ex);
            }
            return result;

        }

        internal static DateTime ConvertToEST(DateTime dateTimeInput)
        {
            TimeZoneInfo local = TimeZoneInfo.Local;
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            dateTimeInput = DateTime.SpecifyKind(dateTimeInput, DateTimeKind.Local);
            DateTime dateTimeEST = TimeZoneInfo.ConvertTime(dateTimeInput, local, est);
            return dateTimeEST;
        }

        internal static int GetUserID(string username)
        {
            int userID = 0;
            try
            {
                string sql = $"SELECT userId FROM user WHERE userName = '{username}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    userID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting userId: " + ex);
            }
            return userID;
        }

        public static string GetUsername(int userID)
        {
            string username = "";
            try
            {
                string sql = $"SELECT userName FROM user WHERE userId = '{userID}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    username = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting userId: " + ex);
            }
            return username;
        }

        public static DataSet FillAppointmentTable()
        {
            DataSet dset = new DataSet();
            try
            {
                string query = "SELECT * FROM appointment";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, DBConnection.conn);
                adpt.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown while filling table:" + ex);
            }
            return dset;
        }

        private static string ChangeValueIfEmpty(string value)
        {
            if (!DataValidation.ValidateText(value))
            {
                value = "not needed";
            }
            return value;
        }

        public static string FormatDateTimeForSQL(DateTime dateTime)
        {
            string formattedDateTime;
            formattedDateTime = dateTime.Year.ToString();
            formattedDateTime = formattedDateTime + "-";
            formattedDateTime = formattedDateTime + dateTime.Month.ToString();
            formattedDateTime = formattedDateTime + "-";
            formattedDateTime = formattedDateTime + dateTime.Day.ToString();
            formattedDateTime = formattedDateTime + " ";
            formattedDateTime = formattedDateTime + dateTime.Hour.ToString();
            formattedDateTime = formattedDateTime + ":";
            formattedDateTime = formattedDateTime + dateTime.Minute.ToString();
            formattedDateTime = formattedDateTime + ":";
            formattedDateTime = formattedDateTime + dateTime.Second.ToString();
            return formattedDateTime;
        }

        public static void DeleteAppointment(string appointmentID)
        {
            try
            {
                int numericalID = Int32.Parse(appointmentID);
                string sql = $"DELETE FROM appointment WHERE appointmentId = {numericalID}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The appointment has been deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error thrown deleting appointment:" + ex);
            }
        }

        internal static int CheckAvailabilityReturnCount(DateTime start, DateTime end, string user, int appointmentID)
        {
            int count = 0;
            string startSQL = FormatDateTimeForSQL(start);
            string endSQL = FormatDateTimeForSQL(end);
            int userID = GetUserID(user);
            try
            {
                string sql = $"SELECT COUNT(*) FROM appointment WHERE userId = {userID} AND (('{startSQL}' BETWEEN start AND end) OR ('{endSQL}' BETWEEN start AND end))";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (count == 1)
                {
                    string sql2 = $"SELECT appointmentId FROM appointment WHERE userId = {userID} AND (('{startSQL}' BETWEEN start AND end) OR ('{endSQL}' BETWEEN start AND end))";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                    using (cmd2)
                    {
                        int foundID = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (foundID == appointmentID)
                        {
                            count = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while checking availability: " + ex);
            }
            return count;
        }

        internal static void UpdateAppointmentLastUpdated(string user, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET lastUpdate = NOW(), lastUpdateBy = '{user}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating 'last updated' appointment fields: " + ex);
            }
        }

        internal static void UpdateAppointmentStartEnd(DateTime start, DateTime end, string user, int appointmentID)
        {
            string startSQL = FormatDateTimeForSQL(start);
            string endSQL = FormatDateTimeForSQL(end);
            try
            {
                string sql2 = $"UPDATE appointment SET start = '{startSQL}', end = '{endSQL}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating start & end fields: " + ex);
            }
        }
    }
}
