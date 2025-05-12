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
            appointmentIDLabel = new Label();
            startLabel = new Label();
            endLabel = new Label();
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
            appointmentGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)appointmentGridView).BeginInit();
            SuspendLayout();
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Segoe UI", 10F);
            selectionLabel.Location = new Point(232, 34);
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
            actionComboBox.Location = new Point(345, 31);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(232, 25);
            actionComboBox.TabIndex = 13;
            actionComboBox.SelectedIndexChanged += actionComboBox_SelectedIndexChanged;
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
            backButton.Click += backButton_Click;
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Enabled = false;
            appointmentIDLabel.Font = new Font("Segoe UI", 10F);
            appointmentIDLabel.Location = new Point(181, 77);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new Size(0, 19);
            appointmentIDLabel.TabIndex = 15;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Segoe UI", 10F);
            startLabel.Location = new Point(30, 99);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(72, 19);
            startLabel.TabIndex = 18;
            startLabel.Text = "Start time:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Enabled = false;
            endLabel.Font = new Font("Segoe UI", 10F);
            endLabel.Location = new Point(181, 99);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(66, 19);
            endLabel.TabIndex = 19;
            endLabel.Text = "End time:";
            // 
            // datePicker
            // 
            datePicker.Enabled = false;
            datePicker.Font = new Font("Segoe UI", 10F);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(108, 71);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(115, 25);
            datePicker.TabIndex = 23;
            datePicker.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F);
            dateLabel.Location = new Point(61, 73);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 19);
            dateLabel.TabIndex = 24;
            dateLabel.Text = "Date:";
            // 
            // startTimePicker
            // 
            startTimePicker.CustomFormat = "HH:MM";
            startTimePicker.Enabled = false;
            startTimePicker.Font = new Font("Segoe UI", 10F);
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(108, 99);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(60, 25);
            startTimePicker.TabIndex = 25;
            startTimePicker.Value = new DateTime(2025, 4, 8, 9, 0, 0, 0);
            // 
            // endTimePicker
            // 
            endTimePicker.CustomFormat = "HH:MM";
            endTimePicker.Enabled = false;
            endTimePicker.Font = new Font("Segoe UI", 10F);
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(251, 99);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.ShowUpDown = true;
            endTimePicker.Size = new Size(60, 25);
            endTimePicker.TabIndex = 26;
            endTimePicker.Value = new DateTime(2025, 4, 8, 10, 0, 0, 0);
            // 
            // userTextBox
            // 
            userTextBox.Enabled = false;
            userTextBox.Font = new Font("Segoe UI", 10F);
            userTextBox.Location = new Point(108, 134);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(176, 25);
            userTextBox.TabIndex = 27;
            // 
            // customerTextBox
            // 
            customerTextBox.Enabled = false;
            customerTextBox.Font = new Font("Segoe UI", 10F);
            customerTextBox.Location = new Point(108, 165);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(176, 25);
            customerTextBox.TabIndex = 28;
            // 
            // locationTextBox
            // 
            locationTextBox.Enabled = false;
            locationTextBox.Font = new Font("Segoe UI", 10F);
            locationTextBox.Location = new Point(108, 196);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(176, 25);
            locationTextBox.TabIndex = 29;
            // 
            // contactTextBox
            // 
            contactTextBox.Enabled = false;
            contactTextBox.Font = new Font("Segoe UI", 10F);
            contactTextBox.Location = new Point(108, 227);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(176, 25);
            contactTextBox.TabIndex = 30;
            // 
            // typeTextBox
            // 
            typeTextBox.Enabled = false;
            typeTextBox.Font = new Font("Segoe UI", 10F);
            typeTextBox.Location = new Point(108, 258);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(176, 25);
            typeTextBox.TabIndex = 31;
            // 
            // titleTextBox
            // 
            titleTextBox.Enabled = false;
            titleTextBox.Font = new Font("Segoe UI", 10F);
            titleTextBox.Location = new Point(108, 289);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(176, 25);
            titleTextBox.TabIndex = 32;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Font = new Font("Segoe UI", 10F);
            descriptionTextBox.Location = new Point(108, 320);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(249, 88);
            descriptionTextBox.TabIndex = 33;
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
            saveButton.Click += saveButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 10F);
            userLabel.Location = new Point(23, 137);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(79, 19);
            userLabel.TabIndex = 36;
            userLabel.Text = "Consultant:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 10F);
            customerLabel.Location = new Point(24, 168);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(78, 19);
            customerLabel.TabIndex = 37;
            customerLabel.Text = "*Customer:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI", 10F);
            locationLabel.Location = new Point(38, 199);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(64, 19);
            locationLabel.TabIndex = 38;
            locationLabel.Text = "Location:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI", 10F);
            contactLabel.Location = new Point(42, 230);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(60, 19);
            contactLabel.TabIndex = 39;
            contactLabel.Text = "Contact:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 10F);
            typeLabel.Location = new Point(62, 261);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(40, 19);
            typeLabel.TabIndex = 40;
            typeLabel.Text = "Type:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 10F);
            titleLabel.Location = new Point(65, 292);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(37, 19);
            titleLabel.TabIndex = 41;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10F);
            descriptionLabel.Location = new Point(21, 323);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(81, 19);
            descriptionLabel.TabIndex = 42;
            descriptionLabel.Text = "Description:";
            // 
            // appointmentGridView
            // 
            appointmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentGridView.Location = new Point(373, 72);
            appointmentGridView.Name = "appointmentGridView";
            appointmentGridView.Size = new Size(415, 315);
            appointmentGridView.TabIndex = 43;
            // 
            // EditAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(appointmentGridView);
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
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Controls.Add(appointmentIDLabel);
            Controls.Add(selectionLabel);
            Controls.Add(actionComboBox);
            Controls.Add(backButton);
            Name = "EditAppointments";
            Text = "Edit appointments";
            ((System.ComponentModel.ISupportInitialize)appointmentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectionLabel;
        private ComboBox actionComboBox;
        private Button backButton;
        private Label appointmentIDLabel;
        private Label startLabel;
        private Label endLabel;
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
        private DataGridView appointmentGridView;
    }
}