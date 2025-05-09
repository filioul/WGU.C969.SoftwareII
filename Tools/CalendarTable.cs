using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WGU.C969.SoftwareII.Tools
{
    internal class CalendarTable
    {
        public static DataSet ShowWeeksAppointments(DateTime selectedDate)
        {
            DataSet dataSet = new DataSet();
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            var selectedWeek = calendar.GetWeekOfYear(selectedDate, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
            if (selectedDate.Month == 1 && selectedWeek > 1)
            {
                selectedWeek = 0;
            }
            try
            {
                string query2 = $"SELECT * FROM appointment WHERE WEEK(start) = {selectedWeek}";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query2, DBConnection.conn);
                adpt.Fill(dataSet);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error filling table with week's data:" + ex);
            }
            return dataSet;
        }

    }
}
