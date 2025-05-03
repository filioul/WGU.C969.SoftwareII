using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
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
        public static void AddCountry(string countryName, string user)
        {
            countryName = countryName.Trim();
            user = user.Trim();
            try
            {
                string sql = $"SELECT * FROM country WHERE country = '{countryName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("country already added");
                    return;
                }
                else
                {
                    reader.Close();
                    string sql2 = $"INSERT INTO country VALUES (NULL, @countryName, NOW(), @createdBy, NOW(), @updatedBy)";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                    cmd2.Parameters.AddWithValue("@countryName", countryName);
                    cmd2.Parameters.AddWithValue("@createdBy", user);
                    cmd2.Parameters.AddWithValue("@updatedBy", user);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("country added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }
        }

        public static int GetCountryID(string countryName)
        {
            int countryID = 0;
            try
            {
                string sql = $"SELECT countryId FROM country WHERE country = '{countryName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    countryID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting countryId: " + ex);
            }
            return countryID;
        }
    }
}
