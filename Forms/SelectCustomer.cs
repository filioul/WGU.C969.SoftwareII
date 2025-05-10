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
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
            DataSet dset = new DataSet();
            dset = Customer.FillCustomerTable();
            customerGridView.DataSource = dset.Tables[0];
        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
