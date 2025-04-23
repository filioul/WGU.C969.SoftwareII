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
    public partial class CalendarView : Form
    {
        public CalendarView()
        {
            InitializeComponent();
            datePicker.CustomFormat = "dd/MM/yyyy";

            TimeZone localTimeZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;

            DateTime currentUTC = localTimeZone.ToUniversalTime(currentDate);
            TimeSpan currentOffset = currentDate - currentUTC;

            DataSet dset = new DataSet();
            try
            {
                string query = "SELECT * FROM appointment";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, DBConnection.conn);
                adpt.Fill(dset);
                appDataGridView.DataSource = dset.Tables[0];
                if (currentDate==currentUTC)
                {
                    appDataGridView.ReadOnly = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown while filling table:" + ex);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desiredDate = datePicker.Value;
                ((DataTable)appDataGridView.DataSource).DefaultView.RowFilter = $"start = '{desiredDate}' ";

            } catch(Exception ex)
            {
                MessageBox.Show("Exception thrown while filling table:" + ex);

            }
        }
    }
}
