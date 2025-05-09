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
    public partial class EditAppointments : Form
    {
        public EditAppointments()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionComboBox.SelectedIndex == 0)
            {
                AddAppointment();
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                UpdateAppointment();
            }
            else if (actionComboBox.SelectedIndex == 2)
            {
                DeleteAppointment();
            }
        }

        private void AddAppointment()
        {
            HideSearchFields();
            ShowPropertyFields();
        }

        private void DeleteAppointment()
        {
            HidePropertyFields();
            ShowSearchFields();
        }

        private void UpdateAppointment()
        {
            HidePropertyFields();
            ShowSearchFields();
        }

        private void ShowPropertyFields()
        {
            datePicker.Visible = true;
            dateLabel.Visible = true;
            startTimePicker.Visible = true;
            startLabel.Visible = true;
            endTimePicker.Visible = true;
            endLabel.Visible = true;
            userLabel.Visible = true;
            userTextBox.Visible = true;
            customerLabel.Visible = true;
            customerTextBox.Visible = true;
            locationLabel.Visible = true;
            locationTextBox.Visible = true;
            contactLabel.Visible = true;
            contactTextBox.Visible = true;
            typeLabel.Visible = true;
            typeTextBox.Visible = true;
            titleLabel.Visible = true;
            titleTextBox.Visible = true;
            descriptionLabel.Visible = true;
            descriptionTextBox.Visible = true;
            saveButton.Visible = true;
            saveButton.Enabled = true;
        }

        private void ShowSearchFields()
        {
            appointmentIDLabel.Visible = true;
            IDTextBox.Visible = true;
            searchButton.Visible = true;
        }

        private void HidePropertyFields()
        {
            datePicker.Visible = false;
            dateLabel.Visible = false;
            startTimePicker.Visible = false;
            startLabel.Visible = false;
            endTimePicker.Visible = false;
            endLabel.Visible = false;
            userLabel.Visible = false;
            userTextBox.Visible = false;
            customerLabel.Visible = false;
            customerTextBox.Visible = false;
            locationLabel.Visible = false;
            locationTextBox.Visible = false;
            contactLabel.Visible = false;
            contactTextBox.Visible = false;
            typeLabel.Visible = false;
            typeTextBox.Visible = false;
            titleLabel.Visible = false;
            titleTextBox.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;
            saveButton.Visible = false;
            saveButton.Enabled = false;
        }

        private void HideSearchFields()
        {
            appointmentIDLabel.Visible = false;
            IDTextBox.Visible = false;
            searchButton.Visible = false;
        }
    }
}
