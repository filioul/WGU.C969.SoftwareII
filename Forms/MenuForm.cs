using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU.C969.SoftwareII.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void editCustomersButton_Click(object sender, EventArgs e)
        {
            EditCustomerRecords editCForm = new EditCustomerRecords();
            editCForm.Show();
        }

        private void editAppointmentsButton_Click(object sender, EventArgs e)
        {
            EditAppointments editAForm = new EditAppointments();
            editAForm.Show();
        }

        private void calendarViewButton_Click(object sender, EventArgs e)
        {
            CalendarView calendarViewForm = new CalendarView();
            calendarViewForm.Show();
        }

        private void generateReportsButton_Click(object sender, EventArgs e)
        {
            GenerateReports generateReportsForm = new GenerateReports();
            generateReportsForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
