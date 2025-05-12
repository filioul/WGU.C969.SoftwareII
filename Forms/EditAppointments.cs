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
    public partial class EditAppointments : Form
    {
        public EditAppointments()
        {
            InitializeComponent();
            DataSet dset = new DataSet();
            dset = Appointment.FillAppointmentTable();
            appointmentGridView.DataSource = dset.Tables[0];
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime start = datePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            DateTime end = datePicker.Value.Date + endTimePicker.Value.TimeOfDay;
            string user = userTextBox.Text.Trim();
            string customerName = customerTextBox.Text.Trim();
            string location = locationTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string type = typeTextBox.Text.Trim();
            string title = titleTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();

            if (actionComboBox.SelectedIndex == 0)
            {
                if (Customer.CheckIfCustomerExistsFromName(customerName))
                {
                    if (Appointment.CheckAvailability(start, end, user) && Appointment.CheckBusinessHours(start, end))
                    {
                        Appointment.AddAppointment(start, end, user, customerName, location, contact, type, title, description);
                    }
                    else 
                    {
                        MessageBox.Show("That time slot is not available, please try again.");
                    }
                }
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                
            }
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
            ShowPropertyFields();
        }

        private void DeleteAppointment()
        {
            HidePropertyFields();
        }

        private void UpdateAppointment()
        {
            HidePropertyFields();
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

    }
}
