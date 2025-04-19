using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class DataValidation
    {
        public static bool UsernameAndPasswordCheck(string username, string password)
        {
            string sql = string.Format("SELECT * FROM user WHERE userName = {username}");
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
        }
    }
}
