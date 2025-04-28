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
            string report = "Appointment types per month:\n";
            string sql = $"SELECT type, start FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dt.DefaultView.Sort = "start asc";
            dt = dt.DefaultView.ToTable();

            string[] types = new string[dt.Rows.Count];
            string[] months = new string[dt.Rows.Count];
            foreach (DataRow row in dt.Rows)
            {
                var type = row["type"].ToString;
                DateTime date = (DateTime)row["start"];
                var month = date.ToString("MMMM");

                types.Append(type);
                months.Append(month);
            }
            
            string[] allMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] uniqueTypesCount = new int[12];
            List<string>[] uniqueTypesPerMonth = new List<string>[12] ;
            for (int i = 0; i < 12; i++ )
            {
                uniqueTypesPerMonth[i] = new List<string>();
            }

            for (int i = 0; i < types.Length; i++)
            {
                string type = types[i];
                string month = months[i];
                MessageBox.Show(month);

                int monthIndex = Array.IndexOf(allMonths, month);
                if (monthIndex != -1)
                {
                    if(!uniqueTypesPerMonth[monthIndex].Contains(type))
                    {
                        uniqueTypesPerMonth[monthIndex].Add(type);
                        uniqueTypesCount[monthIndex]++;
                    }

                }
            }


            for (int i = 0; i < uniqueTypesCount.Length; i++)
            {
                if (uniqueTypesCount[i] > 0)
                {
                    var reportLine = $"{allMonths[i]}: {uniqueTypesCount[i]} unique appointment types.\n";
                    report = report + reportLine;
                }
            }

            return report;
        }
    }
}
