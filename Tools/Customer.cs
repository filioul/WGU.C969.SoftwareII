using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            int countryID = GetCountryID(countryName);
            try
            {
                string sql = $"SELECT * FROM city WHERE city = '{cityName}' AND countryId = {countryID}";
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
                    string sql2 = $"INSERT INTO city VALUES (NULL, @cityName, @countryID, NOW(), @createdBy, NOW(), @updatedBy)";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                    cmd2.Parameters.AddWithValue("@cityName", cityName);
                    cmd2.Parameters.AddWithValue("@countryId", countryID);
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

        public static int GetCityID(string cityName, string countryName)
        {
            int cityID = 0;
            int countryID = GetCountryID(countryName);
            try
            {
                string sql = $"SELECT cityId FROM city WHERE city = '{cityName}' AND countryId = {countryID}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    cityID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting cityID: " + ex);
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

            AddCity(cityName, countryName, user);
            int cityID = GetCityID(cityName, countryName);

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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex);
            }

            return addressID;
        }

        public static void AddCustomer(string customerName, string address1, string address2, string cityName, string countryName, string postalCode, string phone, string user, int active)
        {
            int addressID = Customer.AddAddress(address1, address2, cityName, countryName, postalCode, phone, user);
            try
            {
                string sql2 = $"INSERT INTO customer VALUES (NULL, @customerName, @addressId, @active, NOW(), @createdBy, NOW(), @updatedBy)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.Parameters.AddWithValue("@customerName", customerName);
                cmd2.Parameters.AddWithValue("@addressId", addressID);
                cmd2.Parameters.AddWithValue("@active", active);
                cmd2.Parameters.AddWithValue("@createdBy", user);
                cmd2.Parameters.AddWithValue("@updatedBy", user);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown when creating customer: " + ex);
            }
        }

        public static bool CheckIfCustomerExists(string customerID)
        {
            customerID = customerID.Trim();
            if (!DataValidation.ValidateID(customerID))
            {
                MessageBox.Show("Invalid ID. Please try again.");
                return false;
            } else
            {
                try
                {
                    int numericalID = int.Parse(customerID);
                    string sql = $"SELECT * FROM customer WHERE customerId = {numericalID}";
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
                        MessageBox.Show("The ID does not match any existing users. Please try again.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error thrown searching for customer:" + ex);
                    return false;
                }
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            customerID = customerID.Trim();
            try
            {
                int numericalID = int.Parse(customerID);
                string sql = $"DELETE FROM customer WHERE customerId = {numericalID}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The customer has been deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error thrown deleting customer:" + ex);
            }
        }

        public static void UpdateCustomer(string customerID, string customerName, string address1, string address2, string cityName, string countryName, string postalCode, string number, string user)
        {
            customerID = customerID.Trim();
            try
            {
                int numericalID = int.Parse(customerID);
                if (DataValidation.ValidateText(customerName))
                {
                    UpdateCustomerName(numericalID, customerName);
                    UpdateCustomerLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidateText(address1))
                {
                    UpdateCustomerAddress1(numericalID, address1);
                    UpdateAddressLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidateText(address2))
                {
                    UpdateCustomerAddress2(numericalID, address2);
                    UpdateAddressLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidateText(countryName))
                {
                    UpdateCustomerCountry(numericalID, countryName, user);
                    UpdateAddressLastUpdated(numericalID, user);
                    UpdateCountryLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidateText(cityName))
                {
                    if (!DataValidation.ValidateText(countryName))
                    {
                        countryName = GetCountryFromCustomerID(numericalID);
                    }
                    UpdateCustomerCity(numericalID, cityName, countryName, user);
                    UpdateAddressLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidateText(postalCode))
                {
                    UpdateCustomerPostalCode(numericalID, postalCode, user);
                    UpdateAddressLastUpdated(numericalID, user);
                }
                if (DataValidation.ValidatePhoneNumberNull(number))
                {
                    if (DataValidation.ValidatePhoneNumberFormat(number))
                    {
                        UpdateCustomerPhoneNumber(numericalID, number, user);
                        UpdateAddressLastUpdated(numericalID, user);
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number, please try again.");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error thrown updating customer:" + ex);
            }
        }

        private static void UpdateCustomerName(int customerID, string customerName)
        {
            string sql = $"UPDATE customer SET customerName = '{customerName}' WHERE customerId = {customerID}";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
            cmd.ExecuteNonQuery();
        }
        private static void UpdateCustomerAddress1(int customerID, string address1)
        {

            int addressID = GetAddressID(customerID);
            try
            {
                string sql2 = $"UPDATE address SET address = '{address1}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private static void UpdateCustomerAddress2(int customerID, string address2)
        {
            int addressID = GetAddressID(customerID);
            try
            {
                string sql2 = $"UPDATE address SET address2 = '{address2}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private static void UpdateCustomerCountry(int customerID, string countryName, string user)
        {
            int addressID = GetAddressID(customerID);
            int cityID = GetCityIDFromAddress(addressID);
            try
            {
                string cityName = "";
                string sql = $"SELECT city FROM city WHERE cityId = '{cityID}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    cityName = cmd.ExecuteScalar().ToString();
                }
                AddCity(cityName, countryName, user);
                cityID = GetCityID(cityName, countryName);
                string sql2 = $"UPDATE address SET cityId = '{cityID}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown when updating customer country:" + ex);
            }
        }
        private static void UpdateCustomerCity(int customerID, string cityName, string countryName, string user)
        {
            int addressID = GetAddressID(customerID);
            try
            {
                AddCity(cityName, countryName, user);
                int cityID = GetCityID(cityName, countryName);
                string sql2 = $"UPDATE address SET cityId = '{cityID}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating city: " + ex);
            }
        }

        private static void UpdateCustomerPostalCode(int customerID, string postalCode, string user)
        {
            int addressID = GetAddressID(customerID);
            try
            {
                string sql2 = $"UPDATE address SET postalCode = '{postalCode}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Exception when updating postal code: " + ex);
            }
        }

        private static void UpdateCustomerPhoneNumber(int customerID, string number, string user)
        {
            int addressID = GetAddressID(customerID);
            try
            {
                string sql2 = $"UPDATE address SET phone = '{number}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating phone number: " + ex);
            }
        }

        private static void UpdateAddressLastUpdated(int customerID, string user)
        {
            int addressID = GetAddressID(customerID);
            try
            {
                string sql2 = $"UPDATE address SET lastUpdate = NOW(), lastUpdateBy = '{user}' WHERE addressId = {addressID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Exception when updating 'last updated' address fields: " + ex);
            }
        }

        private static void UpdateCustomerLastUpdated(int customerID, string user) 
        {
            try
            {
                string sql2 = $"UPDATE customer SET lastUpdate = NOW(), lastUpdateBy = '{user}' WHERE customerId = {customerID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating 'last updated' customer fields: " + ex);
            }
        }

        private static void UpdateCountryLastUpdated(int customerID, string user)
        {
            string country = GetCountryFromCustomerID(customerID);
            int countryID = GetCountryID(country);
            try
            {
                string sql2 = $"UPDATE country SET lastUpdate = NOW(), lastUpdateBy = '{user}' WHERE countryId = {countryID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating 'last updated' country fields: " + ex);
            }
        }

        private static void UpdateCityLastUpdated(int customerID, string user)
        {
            int addressID = GetAddressID(customerID);
            int cityID = GetCityIDFromAddress(addressID);
            try
            {
                string sql2 = $"UPDATE city SET lastUpdate = NOW(), lastUpdateBy = '{user}' WHERE cityId = {cityID}";
                MySqlCommand cmd2 = new MySqlCommand(sql2, DBConnection.conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when updating 'last updated' city fields: " + ex);
            }
        }

        private static int GetAddressID(int customerID)
        {
            int addressID = 0;
            try
            {
                string sql = $"SELECT addressId FROM customer WHERE customerId = '{customerID}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    addressID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("Exception thrown getting address id: " + ex);
            }
            return addressID;
        }

        private static int GetCityIDFromAddress(int addressID)
        {
            int cityID = 0;
            try
            {
                string sql = $"SELECT cityId FROM address WHERE addressId = {addressID}";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    cityID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Exception thrown getting city id: " + ex);
            }
            return cityID;
        }

        private static string GetCountryFromCustomerID(int customerID)
        {
            string countryName = "";
            int addressID = GetAddressID(customerID);
            try
            {
                string sql = $"SELECT country FROM country WHERE addressId = '{addressID}'";
                MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
                using (cmd)
                {
                    countryName = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown getting city id: " + ex);
            }
            return countryName;
        }
    }
}
