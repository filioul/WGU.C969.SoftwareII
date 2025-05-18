using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WGU.C969.SoftwareII.Tools
{
    public class Appointment
    {
        public static void AddAppointment(DateTime start, DateTime end, string givenUser, string customerName, string location, string contact, string type, string url, string title, string desc, string user)
        {
            DateTime startUTC = ConvertToUTC(start);
            DateTime endUTC = ConvertToUTC(end);
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
                cmd.Parameters.AddWithValue("@start", startUTC);
                cmd.Parameters.AddWithValue("@end", endUTC);
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
            DateTime startUTC = ConvertToUTC(start);
            DateTime endUTC = ConvertToUTC(end);
            int availability;
            if (!DataValidation.ValidateText(givenUser))
            {
                availability = CheckAvailabilityReturnCount(startUTC, endUTC, originalUser, numericalID);
            } else
            {
                availability = CheckAvailabilityReturnCount(startUTC, endUTC, givenUser, numericalID);
            }

            if (availability == 0)
            {
                UpdateAppointmentStartEnd(startUTC, endUTC, user, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            else
            {
                MessageBox.Show("That time slot is not available, please try again.");
                return;
            }

            if(DataValidation.ValidateText(givenUser))
            {
                UpdateAppointmentConsultant(givenUser, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if(DataValidation.ValidateText(customerName))
            {
                UpdateAppointmentCustomer(customerName, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if(DataValidation.ValidateText(location))
            {
                UpdateAppointmentLocation(location, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if (DataValidation.ValidateText(type))
            {
                UpdateAppointmentType(type, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if (DataValidation.ValidateText(desc))
            {
                UpdateAppointmentDescription(desc, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if (DataValidation.ValidateText(title))
            {
                UpdateAppointmentTitle(title, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if (DataValidation.ValidateText(contact))
            {
                UpdateAppointmentContact(contact, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
            if (DataValidation.ValidateText(url))
            {
                UpdateAppointmentURL(url, numericalID);
                UpdateAppointmentLastUpdated(user, numericalID);
            }
        }

        internal static bool CheckAvailability(DateTime start, DateTime end, string user)
        {
            bool result = true;
            DateTime startUTC = ConvertToUTC(start);
            DateTime endUTC = ConvertToUTC(end);
            string startSQL = FormatDateTimeForSQL(startUTC);
            string endSQL = FormatDateTimeForSQL(endUTC);
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
                DateTime startUTC = ConvertToUTC(start);
                DateTime endUTC = ConvertToUTC(end);
                if (startUTC.TimeOfDay < endUTC.TimeOfDay)
                {
                    if (startUTC.DayOfWeek == endUTC.DayOfWeek
                        && (startUTC.DayOfWeek != DayOfWeek.Sunday || startUTC.DayOfWeek != DayOfWeek.Saturday))
                    {
                        DateTime workdayStart = new DateTime(2000, 01, 01, 9, 0, 0);
                        DateTime workdayEnd = new DateTime(2000, 01, 01, 17, 0, 0, 0);
                        if ((startUTC.TimeOfDay >= workdayStart.TimeOfDay && startUTC.TimeOfDay <= workdayEnd.TimeOfDay) && (endUTC.TimeOfDay >= workdayStart.TimeOfDay && endUTC.TimeOfDay <= workdayEnd.TimeOfDay))
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

        internal static DateTime ConvertToUTC(DateTime dateTimeInput)
        {
            TimeZoneInfo local = TimeZoneInfo.Local;
            TimeZoneInfo utc = TimeZoneInfo.FindSystemTimeZoneById("UTC");
            dateTimeInput = DateTime.SpecifyKind(dateTimeInput, DateTimeKind.Local);
            DateTime dateTimeUST = TimeZoneInfo.ConvertTime(dateTimeInput, local, utc);
            return dateTimeUST;
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

        internal static void UpdateAppointmentConsultant(string user, int appointmentID)
        {
            try
            {
                int userID = GetUserID(user);
                string sql2 = $"UPDATE appointment SET userId = {userID} WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating user field: " + ex);
            }
        }

        private static void UpdateAppointmentCustomer(string customerName, int appointmentID)
        {
            try
            {
                int customerID = Customer.GetCustomerID(customerName);
                string sql2 = $"UPDATE appointment SET customerId = {customerID} WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating customer field: " + ex);
            }
        }

        private static void UpdateAppointmentLocation(string location, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET location = '{location}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating location field: " + ex);
            }
        }

        private static void UpdateAppointmentType(string type, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET type = '{type}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating type field: " + ex);
            }
        }

        private static void UpdateAppointmentDescription(string desc, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET description = '{desc}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating description field: " + ex);
            }
        }

        private static void UpdateAppointmentTitle(string title, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET title = '{title}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating title field: " + ex);
            }
        }

        private static void UpdateAppointmentContact(string contact, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET contact = '{contact}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating title field: " + ex);
            }
        }

        private static void UpdateAppointmentURL(string url, int appointmentID)
        {
            try
            {
                string sql2 = $"UPDATE appointment SET url = '{url}' WHERE appointmentId = {appointmentID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating title field: " + ex);
            }
        }
    }
}
