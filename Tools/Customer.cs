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
            try
            {
                string sql = $"SELECT * FROM country WHERE country = '{countryName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
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

        public static void AddCity(string cityName, string countryName, string user)
        {
            Customer.AddCountry(countryName, user);
            int countryId = GetCountryID(countryName);
            try
            {
                string sql = $"SELECT * FROM city WHERE city = '{cityName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                    string sql2 = $"INSERT INTO city VALUES (NULL, @cityName, @countryId, NOW(), @createdBy, NOW(), @updatedBy)";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                    cmd2.Parameters.AddWithValue("@cityName", cityName);
                    cmd2.Parameters.AddWithValue("@countryId", countryId);
                    cmd2.Parameters.AddWithValue("@createdBy", user);
                    cmd2.Parameters.AddWithValue("@updatedBy", user);
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }
        }

        public static int GetCityID(string cityName)
        {
            int cityID = 0;
            try
            {
                string sql = $"SELECT cityId FROM city WHERE city = '{cityName}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    cityID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting countryId: " + ex);
            }
            return cityID;
        }

        public static int AddAddress(string address1, string address2, string cityName, string countryName, string postalCode, string phone, string user)
        {
            address1 = address1.Trim();
            address2 = address2.Trim();
            cityName = cityName.Trim();
            countryName = countryName.Trim();
            postalCode = postalCode.Trim();
            phone = phone.Trim();
            user = user.Trim();

            Customer.AddCity(cityName, countryName, user);
            int cityID = GetCityID(cityName);

            int addressID = 0;

            try
            {
                string sql2 = $"INSERT INTO address VALUES (NULL, @address1, @address2, @cityId, @postalCode, @phone, NOW(), @createdBy, NOW(), @updatedBy)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.Parameters.AddWithValue("@address1", address1);
                cmd2.Parameters.AddWithValue("@address2", address2);
                cmd2.Parameters.AddWithValue("@postalCode", postalCode);
                cmd2.Parameters.AddWithValue("@phone", phone);
                cmd2.Parameters.AddWithValue("@cityId", cityID);
                cmd2.Parameters.AddWithValue("@createdBy", user);
                cmd2.Parameters.AddWithValue("@updatedBy", user);
                cmd2.ExecuteNonQuery();

                string sql3 = "SELECT MAX(addressId) FROM address";
                MySqlCommand cmd3 = new MySqlCommand(sql3, DBConnection.conn);
                using (cmd3)
                {
                    addressID = Convert.ToInt32(cmd3.ExecuteScalar());
                }
                MessageBox.Show("New address ID: " + addressID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }

            return addressID;
        }

        
    }
}
