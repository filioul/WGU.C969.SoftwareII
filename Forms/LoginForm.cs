using MySql.Data.MySqlClient;
using System.Configuration;

namespace WGU.C969.SoftwareII
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //sets up connection to db
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(constr);
                conn.Open();
                MessageBox.Show("we did it yay");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
