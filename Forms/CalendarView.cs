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
    public partial class CalendarView : Form
    {
        public CalendarView()
        {
            InitializeComponent();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
