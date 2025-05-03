using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
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
            for (int i = 0; i < 12; i++)
            {
                string sql = $"SELECT COUNT(DISTINCT type) FROM appointment WHERE MONTH(start)={i + 1}";
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

        public static DataSet UserSchedule(string user)
        {
            DataSet dset = new DataSet();
            try
            {
                int userID;
                string query1 = $"SELECT userId FROM user WHERE userName= '{user}'";
                MySqlCommand cmd = new MySqlCommand(query1, DBConnection.conn);
                using (cmd)
                {
                    userID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string query2 = $"SELECT * FROM appointment WHERE userId = {userID}";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query2, DBConnection.conn);
                adpt.Fill(dset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown while filling table:" + ex);
            }
            return dset;
        }

        public static string CustomersWithAppointments()
        {
            string report = "";
            List<int> customerIdList = new List<int>();
            DateTime dateTimeNow = DateTime.Now;
            string sql = $"SELECT customerId FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            using (cmd)
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        int value = reader.GetInt32(0);
                        customerIdList.Add(value);
                    }
                }
                reader.Close();
            }
            List<int> uniqueIdList = customerIdList.Distinct().ToList();

            Func<List<int>, string> checkForEmptyList = list => list.Count == 0 ? "No customers with upcoming appointments." : "Customers with appointments:\n";
            report = checkForEmptyList(customerIdList);

            try
            {
                foreach (int customerId in uniqueIdList)
                {
                    string sql2 = $"SELECT customerName FROM customer WHERE customerId = '{customerId}'";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                    string name = "";
                    using (cmd2)
                    {
                        name = Convert.ToString(cmd2.ExecuteScalar());
                        report = report + $"\n{name}";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
            }

            
            return report;
        }
    }
}
