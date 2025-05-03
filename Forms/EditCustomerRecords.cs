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
            ShowPropertyFields();
        }

        private void UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        private void DeleteCustomer()
        {
            throw new NotImplementedException();
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
        }
    }
}
