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
        public static  void ShowDayAppointments(DateTime selectedDate, DataGridView calendarGridView)
        {
            DateTime rowDate = new DateTime();
            int rowIndex;
            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                rowDate = (Convert.ToDateTime(row.Cells["start"].Value)).Date;
                rowIndex = row.Index;
                if (rowDate != selectedDate.Date)
                {
                    CurrencyManager MyCurrencyManager = (CurrencyManager) calendarGridView.BindingContext[calendarGridView.DataSource];
                    MyCurrencyManager.SuspendBinding();
                    calendarGridView.Rows[rowIndex].Visible = false;
                    MyCurrencyManager.ResumeBinding();
                }

            }
        }

    }
}
