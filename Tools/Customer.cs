using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WGU.C969.SoftwareII.Tools
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int addressID { get; set; }
        public DateTime createdTime { get; set; }
        public  string createdBy { get; set; }
        public Timestamp lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public static void addCountry(string countryName, string user)
        {
            DateTime createdTime;
            DateTime lastUpdated;
            try
            {
                string sql = $"SELECT * FROM country WHERE country = '{countryName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                }else
                {
                    createdTime = DateTime.Now;
                    lastUpdated = createdTime;
                    string query = "SELECT countryID FROM country ORDER BY countryID DESC LIMIT 1";
                    var command = new MySqlCommand(query, DBConnection.conn);
                    int countryIndex = Convert.ToInt32(command.ExecuteScalar());
                    MessageBox.Show($"countryIndex");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }
        }
    }
}
