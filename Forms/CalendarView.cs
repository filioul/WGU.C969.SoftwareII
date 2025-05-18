using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGU.C969.SoftwareII.Tools;

namespace WGU.C969.SoftwareII.Forms
{
    public partial class CalendarView : Form
    {
        public CalendarView()
        {
            InitializeComponent();
            datePicker.CustomFormat = "dd/MM/yyyy";

            DataSet dset = Appointment.FillAppointmentTable();
            appDataGridView.DataSource = dset.Tables[0];
            Localization.ChangeTimesToLocal(appDataGridView);
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            DataSet dset = Appointment.FillAppointmentTable();
            appDataGridView.DataSource = dset.Tables[0];
            Localization.ChangeTimesToLocal(appDataGridView);
            DateTime selectedDay = datePicker.Value;
            CalendarTable.ShowDayAppointments(selectedDay, appDataGridView);
        }
    }
}
