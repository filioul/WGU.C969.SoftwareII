namespace WGU.C969.SoftwareII
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            welcomeLabel = new Label();
            greetingLabel = new Label();
            loginButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14F);
            usernameTextBox.Location = new Point(323, 202);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(231, 32);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F);
            passwordTextBox.Location = new Point(323, 258);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(231, 32);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 14F);
            usernameLabel.Location = new Point(220, 205);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(97, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14F);
            passwordLabel.Location = new Point(226, 261);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(91, 25);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 25F);
            welcomeLabel.Location = new Point(323, 96);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(170, 46);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome!";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 14F);
            greetingLabel.Location = new Point(249, 142);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(315, 25);
            greetingLabel.TabIndex = 5;
            greetingLabel.Text = "Please enter your credentials below.";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 12F);
            loginButton.Location = new Point(464, 312);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 45);
            loginButton.TabIndex = 6;
            loginButton.Text = "Sign In";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F);
            exitButton.Location = new Point(697, 393);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(91, 45);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(greetingLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "LoginForm";
            Text = "Welcome!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label welcomeLabel;
        private Label greetingLabel;
        private Button loginButton;
        private Button exitButton;
    }
}
