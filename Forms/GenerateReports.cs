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
    public partial class GenerateReports : Form
    {
        public GenerateReports()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (actionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type of report to generate.");
            }
            else if (actionComboBox.SelectedIndex == 0)
            {
                string report = ReportGenerator.AppointmentTypesPerMonth();
                MessageBox.Show(report);
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                labelUsername.Visible = true;
                textBoxUsername.Visible = true;
                buttonViewSchedule.Visible = true;
            }
        }

        private void buttonViewSchedule_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == null)
            {
                MessageBox.Show("Please type in a valid username.");
            } else if (!DataValidation.UsernameCheck(textBoxUsername.Text))
            {
                MessageBox.Show("Please type in a valid username.");
            } else
            {
                try
                {
                    DataSet dset = ReportGenerator.UserSchedule(textBoxUsername.Text);
                    dataGVUserSchedule.DataSource = dset.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception thrown while filling table:" + ex);
                }
            }
        }
    }
}
