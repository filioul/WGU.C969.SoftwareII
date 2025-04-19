using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class DataValidation
    {
        public static bool UsernameAndPasswordCheck(string username, string password)
        {
            try
            {
                int verify;
                string query = "SELECT count(*) FROM user WHERE userName = " + username + " AND password = " + password;
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                verify = (int)cmd.ExecuteScalar();
                if (verify > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown verifying user: " + ex);
                return false;
            }
        }
    }
}
