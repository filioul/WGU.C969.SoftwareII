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


        public static DateTime ConvertToLocal(DateTime dateTimeInput)
        {
            TimeZoneInfo local = TimeZoneInfo.Local;
            TimeZoneInfo utc = TimeZoneInfo.FindSystemTimeZoneById("UTC");
            dateTimeInput = DateTime.SpecifyKind(dateTimeInput, DateTimeKind.Utc);
            DateTime dateTimeUTC = TimeZoneInfo.ConvertTime(dateTimeInput, utc, local);
            return dateTimeUTC;
        }

        public static void ChangeTimesToLocal(DataGridView dataGridView)
        {
            DateTime lastUpdate = new DateTime();
            DateTime createDate = new DateTime();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                lastUpdate = Convert.ToDateTime(row.Cells["lastUpdate"].Value);
                row.Cells["lastUpdate"].Value = ConvertToLocal(lastUpdate);
                createDate = Convert.ToDateTime(row.Cells["createDate"].Value);
                row.Cells["createDate"].Value = ConvertToLocal(createDate);
            }
            if (dataGridView.Columns.Contains("start"))
            {
                DateTime start = new DateTime();
                DateTime end = new DateTime();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    start = Convert.ToDateTime(row.Cells["start"].Value);
                    row.Cells["start"].Value = ConvertToLocal(start);
                    end = Convert.ToDateTime(row.Cells["end"].Value);
                    row.Cells["end"].Value = ConvertToLocal(end);
                }
            }
        }
    }
}
