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

        public static string NoInputMessage()
        {
            var regionName = DetermineCountry();
            var messageString = "";
            if (regionName == "Greece" || regionName == "Cyprus")
            {
                messageString = "Ελλιπείς στοιχεία. Παρακαλώ προσπαθήστε ξανά.";
            }
            else
            {
                messageString = "Missing input. Please try again.";
            }
            return messageString;
        }

        public static string AppointmentAlertMessage()
        {
            var regionName = DetermineCountry();
            var messageString = "";
            if (regionName == "Greece" || regionName == "Cyprus")
            {
                messageString = "ΠΡΟΣΟΧΗ: Έχετε ραντεβού μέσα στα επόμενα 15 λεπτά.";
            }
            else
            {
                messageString = "ALERT: You have an appointment within the next 15 minutes.";
            }
            return messageString;
        }
    }
}
