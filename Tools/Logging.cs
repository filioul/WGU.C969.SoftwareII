using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    internal class Logging
    {

        public static void RecordSignIn(string user, DateTime loginTime)
        {
            try
            {
                string temp = @"C:969Temp";
                string logFile = @"\Login_History.txt";
                logFile = temp + logFile;

                if (!Directory.Exists(temp))
                {
                    Directory.CreateDirectory(temp);
                }

                using (StreamWriter sw = File.AppendText(logFile))
                {
                    string logEntry = $"Login attempt by {user} at {loginTime}";
                    sw.WriteLine(logEntry);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when logging sign in: " + ex);
            }

        }
    }
}
