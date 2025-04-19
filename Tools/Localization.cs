using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WGU.C969.SoftwareII.Tools
{
    internal class Localization
    {
        public static string DetermineCountry()
        {
            //determines location
            var regionInfo = RegionInfo.CurrentRegion;
            var regionName = regionInfo.EnglishName;
            return regionName;
        }

        public static string WrongCredentialsMessage()
        {
            var regionName = DetermineCountry();
            var messageString = "";
            if (regionName == "Greece" || regionName == "Cyprus")
            {
                messageString = "Λανθασμένο όνομα χρήστη ή κωδικός. Παρακαλώ προσπαθήστε ξανά.";
            }  else
            {
                messageString = "Incorrect username or password. Please try again.";
            }
            return messageString;
        }

    }
}
