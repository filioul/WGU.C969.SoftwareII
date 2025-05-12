namespace WGU.C969.SoftwareII.Forms
{
    partial class EditCustomerRecords
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
            backButton = new Button();
            saveButton = new Button();
            actionComboBox = new ComboBox();
            selectionLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            requiredLabel = new Label();
            addressTextBox1 = new TextBox();
            addressTextBox2 = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            codeTextBox = new TextBox();
            addressLabel1 = new Label();
            addressLabel2 = new Label();
            cityLabel = new Label();
            codeLabel = new Label();
            countryLabel = new Label();
            numberTextBox = new TextBox();
            numberLabel = new Label();
            customerGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 10F);
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(78, 29);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI", 10F);
            saveButton.Location = new Point(697, 393);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 45);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // actionComboBox
            // 
            actionComboBox.Font = new Font("Segoe UI", 10F);
            actionComboBox.FormattingEnabled = true;
            actionComboBox.Items.AddRange(new object[] { "Add a customer", "Update customer details", "Delete a customer" });
            actionComboBox.Location = new Point(345, 41);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(232, 25);
            actionComboBox.TabIndex = 10;
            actionComboBox.SelectedIndexChanged += actionComboBox_SelectedIndexChanged;
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Segoe UI", 10F);
            selectionLabel.Location = new Point(232, 44);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(107, 19);
            selectionLabel.TabIndex = 11;
            selectionLabel.Text = "Select an action:";
            // 
            // nameTextBox
            // 
            nameTextBox.Enabled = false;
            nameTextBox.Font = new Font("Segoe UI", 10F);
            nameTextBox.Location = new Point(163, 104);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(176, 25);
            nameTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F);
            nameLabel.Location = new Point(39, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(118, 19);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "*Customer Name:";
            // 
            // requiredLabel
            // 
            requiredLabel.AutoSize = true;
            requiredLabel.Font = new Font("Segoe UI", 10F);
            requiredLabel.Location = new Point(604, 407);
            requiredLabel.Name = "requiredLabel";
            requiredLabel.Size = new Size(69, 19);
            requiredLabel.TabIndex = 17;
            requiredLabel.Text = "*Required";
            requiredLabel.Visible = false;
            // 
            // addressTextBox1
            // 
            addressTextBox1.Enabled = false;
            addressTextBox1.Font = new Font("Segoe UI", 10F);
            addressTextBox1.Location = new Point(163, 149);
            addressTextBox1.Name = "addressTextBox1";
            addressTextBox1.Size = new Size(176, 25);
            addressTextBox1.TabIndex = 18;
            // 
            // addressTextBox2
            // 
            addressTextBox2.Enabled = false;
            addressTextBox2.Font = new Font("Segoe UI", 10F);
            addressTextBox2.Location = new Point(163, 180);
            addressTextBox2.Name = "addressTextBox2";
            addressTextBox2.Size = new Size(176, 25);
            addressTextBox2.TabIndex = 19;
            // 
            // cityTextBox
            // 
            cityTextBox.Enabled = false;
            cityTextBox.Font = new Font("Segoe UI", 10F);
            cityTextBox.Location = new Point(163, 211);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(126, 25);
            cityTextBox.TabIndex = 20;
            // 
            // countryTextBox
            // 
            countryTextBox.Enabled = false;
            countryTextBox.Font = new Font("Segoe UI", 10F);
            countryTextBox.Location = new Point(163, 242);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(126, 25);
            countryTextBox.TabIndex = 21;
            // 
            // codeTextBox
            // 
            codeTextBox.Enabled = false;
            codeTextBox.Font = new Font("Segoe UI", 10F);
            codeTextBox.Location = new Point(163, 273);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(77, 25);
            codeTextBox.TabIndex = 22;
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Font = new Font("Segoe UI", 10F);
            addressLabel1.Location = new Point(49, 152);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new Size(108, 19);
            addressLabel1.TabIndex = 23;
            addressLabel1.Text = "*Address Line 1:";
            // 
            // addressLabel2
            // 
            addressLabel2.AutoSize = true;
            addressLabel2.Font = new Font("Segoe UI", 10F);
            addressLabel2.Location = new Point(55, 186);
            addressLabel2.Name = "addressLabel2";
            addressLabel2.Size = new Size(102, 19);
            addressLabel2.TabIndex = 24;
            addressLabel2.Text = "Address Line 2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F);
            cityLabel.Location = new Point(115, 214);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(42, 19);
            cityLabel.TabIndex = 25;
            cityLabel.Text = "*City:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI", 10F);
            codeLabel.Location = new Point(67, 276);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(90, 19);
            codeLabel.TabIndex = 26;
            codeLabel.Text = "*Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 10F);
            countryLabel.Location = new Point(89, 245);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(68, 19);
            countryLabel.TabIndex = 27;
            countryLabel.Text = "*Country:";
            // 
            // numberTextBox
            // 
            numberTextBox.Enabled = false;
            numberTextBox.Font = new Font("Segoe UI", 10F);
            numberTextBox.Location = new Point(163, 320);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(176, 25);
            numberTextBox.TabIndex = 28;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI", 10F);
            numberLabel.Location = new Point(49, 323);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(108, 19);
            numberLabel.TabIndex = 29;
            numberLabel.Text = "*Phone Number";
            // 
            // customerGridView
            // 
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Location = new Point(365, 91);
            customerGridView.Name = "customerGridView";
            customerGridView.Size = new Size(415, 281);
            customerGridView.TabIndex = 30;
            // 
            // EditCustomerRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerGridView);
            Controls.Add(numberLabel);
            Controls.Add(numberTextBox);
            Controls.Add(countryLabel);
            Controls.Add(codeLabel);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel2);
            Controls.Add(addressLabel1);
            Controls.Add(codeTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(addressTextBox2);
            Controls.Add(addressTextBox1);
            Controls.Add(requiredLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(selectionLabel);
            Controls.Add(actionComboBox);
            Controls.Add(saveButton);
            Controls.Add(backButton);
            Name = "EditCustomerRecords";
            Text = "Editing customer records";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button saveButton;
        private ComboBox actionComboBox;
        private Label selectionLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label requiredLabel;
        private TextBox addressTextBox1;
        private TextBox addressTextBox2;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private TextBox codeTextBox;
        private Label addressLabel1;
        private Label addressLabel2;
        private Label cityLabel;
        private Label codeLabel;
        private Label countryLabel;
        private TextBox numberTextBox;
        private Label numberLabel;
        private DataGridView customerGridView;
    }
}