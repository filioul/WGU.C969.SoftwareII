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
                var path = Path.Combine(Environment.CurrentDirectory, "Login_History.txt");
                var entry = $"{user} {loginTime}\n";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(entry);
                }
                MessageBox.Show(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when logging sign in: " + ex);
            }

        }
    }
}
