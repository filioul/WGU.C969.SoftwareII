namespace WGU.C969.SoftwareII.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            editCustomersButton = new Button();
            editAppointmentsButton = new Button();
            calendarViewButton = new Button();
            generateReportsButton = new Button();
            exitButton = new Button();
            greetingLabel = new Label();
            SuspendLayout();
            // 
            // editCustomersButton
            // 
            editCustomersButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            editCustomersButton.Font = new Font("Segoe UI", 12F);
            editCustomersButton.Location = new Point(219, 132);
            editCustomersButton.Name = "editCustomersButton";
            editCustomersButton.Size = new Size(346, 45);
            editCustomersButton.TabIndex = 7;
            editCustomersButton.Text = "Edit customer records";
            editCustomersButton.UseVisualStyleBackColor = true;
            // 
            // editAppointmentsButton
            // 
            editAppointmentsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            editAppointmentsButton.Font = new Font("Segoe UI", 12F);
            editAppointmentsButton.Location = new Point(219, 183);
            editAppointmentsButton.Name = "editAppointmentsButton";
            editAppointmentsButton.Size = new Size(346, 45);
            editAppointmentsButton.TabIndex = 8;
            editAppointmentsButton.Text = "Edit appointments";
            editAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // calendarViewButton
            // 
            calendarViewButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            calendarViewButton.Font = new Font("Segoe UI", 12F);
            calendarViewButton.Location = new Point(219, 234);
            calendarViewButton.Name = "calendarViewButton";
            calendarViewButton.Size = new Size(346, 45);
            calendarViewButton.TabIndex = 9;
            calendarViewButton.Text = "Calendar View";
            calendarViewButton.UseVisualStyleBackColor = true;
            // 
            // generateReportsButton
            // 
            generateReportsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            generateReportsButton.Font = new Font("Segoe UI", 12F);
            generateReportsButton.Location = new Point(219, 285);
            generateReportsButton.Name = "generateReportsButton";
            generateReportsButton.Size = new Size(346, 45);
            generateReportsButton.TabIndex = 10;
            generateReportsButton.Text = "Generate reports";
            generateReportsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F);
            exitButton.Location = new Point(697, 393);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(91, 45);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 14F);
            greetingLabel.Location = new Point(297, 90);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(208, 25);
            greetingLabel.TabIndex = 12;
            greetingLabel.Text = "Select an option below.";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(greetingLabel);
            Controls.Add(exitButton);
            Controls.Add(generateReportsButton);
            Controls.Add(calendarViewButton);
            Controls.Add(editAppointmentsButton);
            Controls.Add(editCustomersButton);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editCustomersButton;
        private Button editAppointmentsButton;
        private Button calendarViewButton;
        private Button generateReportsButton;
        private Button exitButton;
        private Label greetingLabel;
    }
}