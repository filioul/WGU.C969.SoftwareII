using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class DataValidation
    {
        public static bool UsernameAndPasswordCheck(string username, string password)
        {
            try
            {
                string sql = $"SELECT * FROM user WHERE userName = '{username}' AND password = '{password}'";
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
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown verifying user: " + ex);
                return false;
            }
        }

        public static bool UsernameCheck(string username)
        {
            try
            {
                string sql = $"SELECT * FROM user WHERE userName = '{username}'";
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
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown verifying username: " + ex);
                return false;
            }
        }

        public static bool ValidateText(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(phoneNumber, @"^[\d\-]+$");
            }
        }

        public static bool ValidateID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;
            } else
            {
                return Regex.IsMatch(id, @"^\d+$");
            }
        }
    }
}
