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
            } else if (actionComboBox.SelectedIndex == 0) {
                string report = ReportGenerator.AppointmentTypesPerMonth();
                MessageBox.Show(report);
            }
        }
    }
}
