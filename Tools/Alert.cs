using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class Alert
    {
        public static bool CheckIfAppointmentWithin15(string username, string password)
        {
            DateTime timeNow = DateTime.Now;
            DateTime timeIn15 = timeNow.AddMinutes(15);
            string sql = $"SELECT * FROM appointment WHERE start BETWEEN '{timeNow}' AND '{timeIn15}'";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
