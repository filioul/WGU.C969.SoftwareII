using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class ReportGenerator
    {
        public static string AppointmentTypesPerMonth()
        {
            string report = "Unique appointment types per month:\n";
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int distinctTypes = 0;
            for (int i = 0; i<12; i++) 
            {
                string sql = $"SELECT COUNT(DISTINCT type) FROM appointment WHERE MONTH(start)={i+1}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    distinctTypes = Convert.ToInt32(cmd.ExecuteScalar());
                }
                Func<int, int> checkValue = i => i == -1 ? 0 : i; //lambda expression checks if no distinct types where found, replaces the default -1 value with 0
                report = report + $"{months[i]}: {distinctTypes}\n";
            }
            return report;
        }
    }
}
