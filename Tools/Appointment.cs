using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    public class Appointment
    {
        public static void AddAppointment(DateTime start, DateTime end, string user, string customerName, string location, string contact, string type, string title, string desc)
        {

        }

        internal static bool CheckAvailability(DateTime start, DateTime end, string user)
        {
            bool result = true;
            DateTime startEST = ConvertToEST(start);
            DateTime endEST = ConvertToEST(end);
            int userID = GetUserID(user);
            try
            {
                string sql = $"SELECT * FROM appointment WHERE DATE(start) = {startEST.Date} AND userId = {userID}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    
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
            try {
                DateTime startEST = ConvertToEST(start);
                DateTime endEST = ConvertToEST(end);
                if (startEST.TimeOfDay < endEST.TimeOfDay)
                {
                    if (startEST.DayOfWeek == endEST.DayOfWeek
                        && (startEST.DayOfWeek != DayOfWeek.Sunday || startEST.DayOfWeek != DayOfWeek.Saturday))
                    {
                        result = true;
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
            var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime dateTimeEST = TimeZoneInfo.ConvertTime(dateTimeInput, est);
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
    }
}
