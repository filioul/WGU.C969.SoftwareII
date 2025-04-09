namespace WGU.C969.SoftwareII.Forms
{
    partial class EditAppointments
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
            selectionLabel = new Label();
            actionComboBox = new ComboBox();
            backButton = new Button();
            searchButton = new Button();
            IDTextBox = new TextBox();
            appointmentIDLabel = new Label();
            startLabel = new Label();
            endLabel = new Label();
            checkAvailButton = new Button();
            datePicker = new DateTimePicker();
            dateLabel = new Label();
            startTimePicker = new DateTimePicker();
            endTimePicker = new DateTimePicker();
            userTextBox = new TextBox();
            customerTextBox = new TextBox();
            locationTextBox = new TextBox();
            contactTextBox = new TextBox();
            typeTextBox = new TextBox();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            requiredLabel = new Label();
            saveButton = new Button();
            userLabel = new Label();
            customerLabel = new Label();
            locationLabel = new Label();
            contactLabel = new Label();
            typeLabel = new Label();
            titleLabel = new Label();
            descriptionLabel = new Label();
            SuspendLayout();
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Segoe UI", 10F);
            selectionLabel.Location = new Point(232, 44);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(107, 19);
            selectionLabel.TabIndex = 14;
            selectionLabel.Text = "Select an action:";
            // 
            // actionComboBox
            // 
            actionComboBox.Font = new Font("Segoe UI", 10F);
            actionComboBox.FormattingEnabled = true;
            actionComboBox.Items.AddRange(new object[] { "Add an appointment", "Update appointment details", "Delete an appointment" });
            actionComboBox.Location = new Point(345, 41);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(232, 25);
            actionComboBox.TabIndex = 13;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 10F);
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(78, 29);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(527, 87);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Visible = false;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 10F);
            IDTextBox.Location = new Point(345, 86);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(176, 25);
            IDTextBox.TabIndex = 16;
            IDTextBox.Visible = false;
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new Font("Segoe UI", 10F);
            appointmentIDLabel.Location = new Point(228, 89);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new Size(111, 19);
            appointmentIDLabel.TabIndex = 15;
            appointmentIDLabel.Text = "Appointment ID:";
            appointmentIDLabel.Visible = false;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Segoe UI", 10F);
            startLabel.Location = new Point(107, 164);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(72, 19);
            startLabel.TabIndex = 18;
            startLabel.Text = "Start time:";
            startLabel.Visible = false;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Segoe UI", 10F);
            endLabel.Location = new Point(291, 164);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(66, 19);
            endLabel.TabIndex = 19;
            endLabel.Text = "End time:";
            endLabel.Visible = false;
            // 
            // checkAvailButton
            // 
            checkAvailButton.Location = new Point(473, 162);
            checkAvailButton.Name = "checkAvailButton";
            checkAvailButton.Size = new Size(129, 23);
            checkAvailButton.TabIndex = 22;
            checkAvailButton.Text = "Check availability";
            checkAvailButton.UseVisualStyleBackColor = true;
            checkAvailButton.Visible = false;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Segoe UI", 10F);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(185, 132);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(115, 25);
            datePicker.TabIndex = 23;
            datePicker.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            datePicker.Visible = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F);
            dateLabel.Location = new Point(138, 138);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 19);
            dateLabel.TabIndex = 24;
            dateLabel.Text = "Date:";
            dateLabel.Visible = false;
            // 
            // startTimePicker
            // 
            startTimePicker.CustomFormat = "HH:MM";
            startTimePicker.Font = new Font("Segoe UI", 10F);
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(185, 160);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(100, 25);
            startTimePicker.TabIndex = 25;
            startTimePicker.Value = new DateTime(2025, 4, 8, 9, 0, 0, 0);
            startTimePicker.Visible = false;
            // 
            // endTimePicker
            // 
            endTimePicker.CustomFormat = "HH:MM";
            endTimePicker.Font = new Font("Segoe UI", 10F);
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(363, 160);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.ShowUpDown = true;
            endTimePicker.Size = new Size(100, 25);
            endTimePicker.TabIndex = 26;
            endTimePicker.Value = new DateTime(2025, 4, 8, 10, 0, 0, 0);
            endTimePicker.Visible = false;
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Segoe UI", 10F);
            userTextBox.Location = new Point(138, 207);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(176, 25);
            userTextBox.TabIndex = 27;
            userTextBox.Visible = false;
            // 
            // customerTextBox
            // 
            customerTextBox.Font = new Font("Segoe UI", 10F);
            customerTextBox.Location = new Point(138, 238);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(176, 25);
            customerTextBox.TabIndex = 28;
            customerTextBox.Visible = false;
            // 
            // locationTextBox
            // 
            locationTextBox.Font = new Font("Segoe UI", 10F);
            locationTextBox.Location = new Point(138, 269);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(176, 25);
            locationTextBox.TabIndex = 29;
            locationTextBox.Visible = false;
            // 
            // contactTextBox
            // 
            contactTextBox.Font = new Font("Segoe UI", 10F);
            contactTextBox.Location = new Point(138, 300);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(176, 25);
            contactTextBox.TabIndex = 30;
            contactTextBox.Visible = false;
            // 
            // typeTextBox
            // 
            typeTextBox.Font = new Font("Segoe UI", 10F);
            typeTextBox.Location = new Point(473, 207);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(176, 25);
            typeTextBox.TabIndex = 31;
            typeTextBox.Visible = false;
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Segoe UI", 10F);
            titleTextBox.Location = new Point(473, 238);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(176, 25);
            titleTextBox.TabIndex = 32;
            titleTextBox.Visible = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 10F);
            descriptionTextBox.Location = new Point(473, 269);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(249, 88);
            descriptionTextBox.TabIndex = 33;
            descriptionTextBox.Visible = false;
            // 
            // requiredLabel
            // 
            requiredLabel.AutoSize = true;
            requiredLabel.Font = new Font("Segoe UI", 10F);
            requiredLabel.Location = new Point(604, 407);
            requiredLabel.Name = "requiredLabel";
            requiredLabel.Size = new Size(69, 19);
            requiredLabel.TabIndex = 35;
            requiredLabel.Text = "*Required";
            requiredLabel.Visible = false;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI", 10F);
            saveButton.Location = new Point(697, 393);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 45);
            saveButton.TabIndex = 34;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 10F);
            userLabel.Location = new Point(53, 210);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(79, 19);
            userLabel.TabIndex = 36;
            userLabel.Text = "Consultant:";
            userLabel.Visible = false;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 10F);
            customerLabel.Location = new Point(54, 241);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(78, 19);
            customerLabel.TabIndex = 37;
            customerLabel.Text = "*Customer:";
            customerLabel.Visible = false;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI", 10F);
            locationLabel.Location = new Point(68, 272);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(64, 19);
            locationLabel.TabIndex = 38;
            locationLabel.Text = "Location:";
            locationLabel.Visible = false;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI", 10F);
            contactLabel.Location = new Point(72, 303);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(60, 19);
            contactLabel.TabIndex = 39;
            contactLabel.Text = "Contact:";
            contactLabel.Visible = false;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 10F);
            typeLabel.Location = new Point(427, 210);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(40, 19);
            typeLabel.TabIndex = 40;
            typeLabel.Text = "Type:";
            typeLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 10F);
            titleLabel.Location = new Point(430, 241);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(37, 19);
            titleLabel.TabIndex = 41;
            titleLabel.Text = "Title:";
            titleLabel.Visible = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10F);
            descriptionLabel.Location = new Point(386, 272);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(81, 19);
            descriptionLabel.TabIndex = 42;
            descriptionLabel.Text = "Description:";
            descriptionLabel.Visible = false;
            // 
            // EditAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(typeLabel);
            Controls.Add(contactLabel);
            Controls.Add(locationLabel);
            Controls.Add(customerLabel);
            Controls.Add(userLabel);
            Controls.Add(requiredLabel);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(customerTextBox);
            Controls.Add(userTextBox);
            Controls.Add(endTimePicker);
            Controls.Add(startTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(datePicker);
            Controls.Add(checkAvailButton);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(searchButton);
            Controls.Add(IDTextBox);
            Controls.Add(appointmentIDLabel);
            Controls.Add(selectionLabel);
            Controls.Add(actionComboBox);
            Controls.Add(backButton);
            Name = "EditAppointments";
            Text = "Edit appointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectionLabel;
        private ComboBox actionComboBox;
        private Button backButton;
        private Button searchButton;
        private TextBox IDTextBox;
        private Label appointmentIDLabel;
        private Label startLabel;
        private Label endLabel;
        private Button checkAvailButton;
        private DateTimePicker datePicker;
        private Label dateLabel;
        private DateTimePicker startTimePicker;
        private DateTimePicker endTimePicker;
        private TextBox userTextBox;
        private TextBox customerTextBox;
        private TextBox locationTextBox;
        private TextBox contactTextBox;
        private TextBox typeTextBox;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label requiredLabel;
        private Button saveButton;
        private Label userLabel;
        private Label customerLabel;
        private Label locationLabel;
        private Label contactLabel;
        private Label typeLabel;
        private Label titleLabel;
        private Label descriptionLabel;
    }
}