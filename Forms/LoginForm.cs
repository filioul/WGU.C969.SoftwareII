using MySql.Data.MySqlClient;
using System.Configuration;
using WGU.C969.SoftwareII.Tools;



namespace WGU.C969.SoftwareII
{
    public partial class LoginForm : Form
    {

        string regionName = Localization.DetermineCountry();
        public LoginForm()
        {
            InitializeComponent();
            ChangeLanguageIfNecessary(regionName);

        }
        private void ChangeLanguageIfNecessary(string regionName)
        {
            //changes text to greek if the user is located in greece or cyprus
            if (regionName == "Greece" || regionName == "Cyprus")
            {
                welcomeLabel.Text = "Καλωσορίσατε";
                greetingLabel.Text = "Παρακαλώ συμπληρώστε τα στοιχεία σας παρακάτω.";
                usernameLabel.Text = "Όνομα χρήστη";
                passwordLabel.Text = "Κωδικός";
                loginButton.Text = "Σύνδεση";
                exitButton.Text = "Έξοδος";
            }
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

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //validates username and password
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            if (DataValidation.UsernameAndPasswordCheck(username, password))
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
