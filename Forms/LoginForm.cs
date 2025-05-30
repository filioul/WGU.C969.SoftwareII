﻿using MySql.Data.MySqlClient;
using System.Configuration;
using WGU.C969.SoftwareII.Forms;
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
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(usernameTextBox.Text))
            {
                var username = usernameTextBox.Text;
                var password = passwordTextBox.Text;
                if (DataValidation.UsernameAndPasswordCheck(username, password))
                {
                    var loginTime = DateTime.UtcNow;
                    Logging.RecordSignIn(username, loginTime);

                    MenuForm menu = new MenuForm(username);
                    menu.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show(Localization.WrongCredentialsMessage());
                }
            }
            else
            {
                MessageBox.Show(Localization.NoInputMessage());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
