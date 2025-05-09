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
    public partial class EditCustomerRecords : Form
    {
        private string user;
        public EditCustomerRecords(string _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionComboBox.SelectedIndex == 0)
            {
                AddCustomer();
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                UpdateCustomer();
            }
            else if (actionComboBox.SelectedIndex == 2)
            {
                DeleteCustomer();
            }
        }

        private void AddCustomer()
        {
            HideUserSearchFields();
            HideDeleteFields();
            ShowPropertyFields();
        }

        private void UpdateCustomer()
        {
            HidePropertyFields();
            HideDeleteFields();
            ShowUserSearchFields();
        }

        private void DeleteCustomer()
        {
            HidePropertyFields();
            ShowUserSearchFields();
        }

        private void ShowPropertyFields()
        {
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            addressLabel1.Visible = true;
            addressTextBox1.Visible = true;
            addressLabel2.Visible = true;
            addressTextBox2.Visible = true;
            cityLabel.Visible = true;
            cityTextBox.Visible = true;
            countryLabel.Visible = true;
            countryTextBox.Visible = true;
            codeLabel.Visible = true;
            codeTextBox.Visible = true;
            numberLabel.Visible = true;
            numberTextBox.Visible = true;
            saveButton.Enabled = true;
        }

        private void HidePropertyFields()
        {
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            addressLabel1.Visible = false;
            addressTextBox1.Visible = false;
            addressLabel2.Visible = false;
            addressTextBox2.Visible = false;
            cityLabel.Visible = false;
            cityTextBox.Visible = false;
            countryLabel.Visible = false;
            countryTextBox.Visible = false;
            codeLabel.Visible = false;
            codeTextBox.Visible = false;
            numberLabel.Visible = false;
            numberTextBox.Visible = false;
            saveButton.Enabled = false;
        }

        private void HideUserSearchFields()
        {
            customerIDLabel.Visible = false;
            IDTextBox.Visible = false;
            searchButton.Visible = false;
        }

        private void ShowUserSearchFields()
        {
            customerIDLabel.Visible = true;
            IDTextBox.Visible = true;
            searchButton.Visible = true;
            IDTextBox.Enabled = true;
            searchButton.Enabled = true;
        }

        private void ShowDeleteFields()
        {
            labelAreYouSure.Visible = true;
            buttonCancel.Visible = true;
            buttonImSure.Visible = true;
        }
        private void HideDeleteFields()
        {
            labelAreYouSure.Visible = false;
            buttonCancel.Visible = false;
            buttonImSure.Visible = false;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName = nameTextBox.Text.Trim();
            string address = addressTextBox1.Text.Trim();
            string address2 = addressTextBox2.Text.Trim();
            string cityName = cityTextBox.Text.Trim();
            string countryName = countryTextBox.Text.Trim();
            string postalCode = codeTextBox.Text.Trim();
            string number = numberTextBox.Text.Trim();
            if (actionComboBox.SelectedIndex == 0)
            {
                if (!DataValidation.ValidateText(customerName))
                {
                    MessageBox.Show("Please enter a valid customer name.");
                }
                else if (!DataValidation.ValidateText(address))
                {
                    MessageBox.Show("Please enter a valid address.");
                }
                else if (!DataValidation.ValidateText(cityName))
                {
                    MessageBox.Show("Please enter a valid address.");
                }
                else if (!DataValidation.ValidateText(countryName))
                {
                    MessageBox.Show("Please enter a valid address.");
                }
                else if (!DataValidation.ValidateText(postalCode))
                {
                    MessageBox.Show("Please enter a valid address.");
                }
                else if (!(DataValidation.ValidatePhoneNumberNull(number) && DataValidation.ValidatePhoneNumberFormat(number)))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                } else {
                    Customer.AddCustomer(customerName, address, address2, cityName, countryName, postalCode, number, user, 1);
                    MessageBox.Show("Customer added successfully.");
                    this.Close();
                } 
            } else if (actionComboBox.SelectedIndex == 1) 
            {
                string customerID = IDTextBox.Text;
                int changes = Customer.UpdateCustomer(customerID, customerName, address, address2, cityName, countryName, postalCode, number, user);
                if (changes > 0)
                {
                    MessageBox.Show("Customer updated successfully.");
                    this.Close();
                } else if (changes == 0)
                {
                    MessageBox.Show("No updates made. Please enter your desired updates.");
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string customerID = IDTextBox.Text;
            if (Customer.CheckIfCustomerExists(customerID))
            {
                ShowUserSearchFields();
                IDTextBox.Enabled = false;
                searchButton.Enabled = false;
                if (actionComboBox.SelectedIndex == 2)
                {
                    ShowDeleteFields();
                } else if (actionComboBox.SelectedIndex == 1)
                {
                    ShowPropertyFields();
                }
            }
        }

        private void buttonImSure_Click(object sender, EventArgs e)
        {
            string customerID = IDTextBox.Text;
            Customer.DeleteCustomer(customerID);
            this.Close();
        }
    }
}

