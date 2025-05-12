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
            DataSet dset = new DataSet();
            dset = Customer.FillCustomerTable();
            customerGridView.DataSource = dset.Tables[0];
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

        private void UpdateCustomer()
        {
            EnablePropertyFields();
        }

        private void DeleteCustomer()
        {
            DisablePropertyFields();
        }

        private void AddCustomer()
        {
            EnablePropertyFields();
        }

        private void DisablePropertyFields()
        {
            nameTextBox.Enabled = false;
            addressTextBox1.Enabled = false;
            addressTextBox2.Enabled = false;
            cityTextBox.Enabled = false;
            countryTextBox.Enabled = false;
            codeTextBox.Enabled = false;
            numberTextBox.Enabled = false;
            saveButton.Enabled = true;
        }

        private void EnablePropertyFields()
        {
            nameTextBox.Enabled = true;
            addressTextBox1.Enabled = true;
            addressTextBox2.Enabled = true;
            cityTextBox.Enabled = true;
            countryTextBox.Enabled = true;
            codeTextBox.Enabled = true;
            numberTextBox.Enabled = true;
            saveButton.Enabled = true;
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
                }
                else
                {
                    Customer.AddCustomer(customerName, address, address2, cityName, countryName, postalCode, number, user, 1);
                    MessageBox.Show("Customer added successfully.");
                    this.Close();
                }
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                if (customerGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    try
                    {
                        DataGridViewRow selectedRow = customerGridView.SelectedRows[0];
                        string customerID = selectedRow.Cells["customerId"].Value.ToString();

                        int changes = Customer.UpdateCustomer(customerID, customerName, address, address2, cityName, countryName, postalCode, number, user);
                        if (changes > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                            this.Close();
                        }
                        else if (changes == 0)
                        {
                            MessageBox.Show("No updates made. Please enter your desired updates.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error selecting row / updating customer: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please select one customer to edit.");
                }

            }
            else if (actionComboBox.SelectedIndex == 2)
            {
                if (customerGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    try
                    {
                        DataGridViewRow selectedRow = customerGridView.SelectedRows[0];
                        string customerID = selectedRow.Cells["customerId"].Value.ToString();
                        Customer.DeleteCustomer(customerID);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Please select one customer to delete.");
                }
            }

        }
    }
} 


