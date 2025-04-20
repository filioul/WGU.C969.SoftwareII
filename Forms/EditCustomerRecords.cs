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
                addCustomer();
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                updateCustomer();
            } 
            else if (actionComboBox.SelectedIndex == 2)
            {
                deleteCustomer();
            }
        }

        private void addCustomer()
        {
            IDTextBox.Enabled = false;
            IDTextBox.Visible = true;
            customerIDLabel.Visible = true;
        }

        private void updateCustomer()
        {
            throw new NotImplementedException();
        }

        private void deleteCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
