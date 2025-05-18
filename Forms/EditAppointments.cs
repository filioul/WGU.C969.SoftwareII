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
        private string user;
        public EditAppointments(string _user)
        {
            user = _user;
            InitializeComponent();
            DataSet dset = new DataSet();
            dset = Appointment.FillAppointmentTable();
            appointmentGridView.DataSource = dset.Tables[0];
            Localization.ChangeTimesToLocal(appointmentGridView);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime start = datePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            DateTime end = datePicker.Value.Date + endTimePicker.Value.TimeOfDay;
            string givenUser = userTextBox.Text.Trim();
            string customerName = customerTextBox.Text.Trim();
            string location = locationTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string type = typeTextBox.Text.Trim();
            string title = titleTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            string url = textBoxURL.Text.Trim();

            if (actionComboBox.SelectedIndex == 0)
            {
                if (Customer.CheckIfCustomerExistsFromName(customerName))
                {
                    if (DataValidation.UsernameCheck(givenUser))
                    {
                        if (Appointment.CheckAvailability(start, end, givenUser) && Appointment.CheckBusinessHours(start, end))
                        {

                            Appointment.AddAppointment(start, end, givenUser, customerName, location, contact, type, title, url, description, user);
                            MessageBox.Show("The appointment was created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("That time slot is not available, please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid consultant.");
                    }

                }
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                if (appointmentGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    try
                    {
                        DataGridViewRow selectedRow = appointmentGridView.SelectedRows[0];
                        string appointmentID = selectedRow.Cells["appointmentId"].Value.ToString();
                        int userID = Convert.ToInt32(selectedRow.Cells["userId"].Value);
                        string originalUsername = Appointment.GetUsername(userID);
                        int customerID = Convert.ToInt32(selectedRow.Cells["customerId"].Value);
                        string originalCustomerName = Customer.GetCustomerName(customerID);

                        bool wasAUsernameGiven = DataValidation.ValidateText(givenUser);
                        bool wasACustomerGiven = DataValidation.ValidateText(customerName);

                        if (!wasAUsernameGiven)
                        {
                            givenUser = "";
                        }

                        if (!wasACustomerGiven)
                        {
                            customerName = "";
                        }

                        if (DataValidation.UsernameCheck(givenUser) || !wasAUsernameGiven)
                        {
                            if (!wasACustomerGiven || Customer.CheckIfCustomerExistsFromName(customerName))
                            {
                                if (Appointment.CheckBusinessHours(start, end))
                                {
                                    Appointment.UpdateAppointment(start, end, givenUser, customerName, location, contact, type, url, title, description, user, appointmentID, originalUsername);
                                    MessageBox.Show("The appointment was updated successfully.");
                                } else
                                {
                                    MessageBox.Show("That time slot is not available, please try again.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid consultant.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating appointment: " + ex);
                    }


                }

                else
                {
                    MessageBox.Show("Please select one appointment to update.");
                }
            }
            else if (actionComboBox.SelectedIndex == 2)
            {
                if (appointmentGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    try
                    {
                        DataGridViewRow selectedRow = appointmentGridView.SelectedRows[0];
                        string appointmentID = selectedRow.Cells["appointmentId"].Value.ToString();
                        Appointment.DeleteAppointment(appointmentID);
                        MessageBox.Show("The appointment was deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting appointment: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please select one appointment to delete.");
                }
            }
            DataSet dset2 = new DataSet();
            dset2 = Appointment.FillAppointmentTable();
            appointmentGridView.DataSource = dset2.Tables[0];
            Localization.ChangeTimesToLocal(appointmentGridView);
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
            saveButton.Enabled = true;
        }

        private void UpdateAppointment()
        {
            ShowPropertyFields();
        }

        private void ShowPropertyFields()
        {
            datePicker.Enabled = true;
            startTimePicker.Enabled = true;
            endTimePicker.Enabled = true;
            userTextBox.Enabled = true;
            customerTextBox.Enabled = true;
            locationTextBox.Enabled = true;
            contactTextBox.Enabled = true;
            typeTextBox.Enabled = true;
            titleTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            textBoxURL.Enabled = true;
            saveButton.Enabled = true;

        }


        private void HidePropertyFields()
        {
            datePicker.Enabled = false;
            startTimePicker.Enabled = false;
            endTimePicker.Enabled = false;
            userTextBox.Enabled = false;
            customerTextBox.Enabled = false;
            locationTextBox.Enabled = false;
            contactTextBox.Enabled = false;
            typeTextBox.Enabled = false;
            titleTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            textBoxURL.Enabled = false;
        }
    
    }
}
