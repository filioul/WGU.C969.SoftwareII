﻿using System;
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
    public partial class MenuForm : Form
    {
        private string user;
        public MenuForm(string _user)
        {
            user = _user;
            InitializeComponent();
            if(Alert.CheckIfAppointmentWithin15(user))
            {
                MessageBox.Show("ALERT: You have an appointment within 15 minutes.");
            }
        }

        private void editCustomersButton_Click(object sender, EventArgs e)
        {
            EditCustomerRecords editCForm = new EditCustomerRecords(user);
            editCForm.Show();
        }

        private void editAppointmentsButton_Click(object sender, EventArgs e)
        {
            EditAppointments editAForm = new EditAppointments(user);
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
