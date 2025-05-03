namespace WGU.C969.SoftwareII.Forms
{
    partial class GenerateReports
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
            selectionLabel = new Label();
            actionComboBox = new ComboBox();
            generateButton = new Button();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            buttonViewSchedule = new Button();
            dataGVUserSchedule = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGVUserSchedule).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 10F);
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(78, 29);
            backButton.TabIndex = 13;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // selectionLabel
            // 
            selectionLabel.AutoSize = true;
            selectionLabel.Font = new Font("Segoe UI", 10F);
            selectionLabel.Location = new Point(232, 44);
            selectionLabel.Name = "selectionLabel";
            selectionLabel.Size = new Size(107, 19);
            selectionLabel.TabIndex = 16;
            selectionLabel.Text = "Select an action:";
            // 
            // actionComboBox
            // 
            actionComboBox.Font = new Font("Segoe UI", 10F);
            actionComboBox.FormattingEnabled = true;
            actionComboBox.Items.AddRange(new object[] { "Number of appointment types by month", "Schedule for each user", "List of customers with appointments" });
            actionComboBox.Location = new Point(345, 41);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(361, 25);
            actionComboBox.TabIndex = 15;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(437, 72);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(140, 23);
            generateButton.TabIndex = 28;
            generateButton.Text = "Generate report";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(265, 104);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(74, 19);
            labelUsername.TabIndex = 29;
            labelUsername.Text = "Username:";
            labelUsername.Visible = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(345, 103);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(145, 23);
            textBoxUsername.TabIndex = 30;
            textBoxUsername.Visible = false;
            // 
            // buttonViewSchedule
            // 
            buttonViewSchedule.Location = new Point(496, 103);
            buttonViewSchedule.Name = "buttonViewSchedule";
            buttonViewSchedule.Size = new Size(126, 23);
            buttonViewSchedule.TabIndex = 31;
            buttonViewSchedule.Text = "View user schedule";
            buttonViewSchedule.UseVisualStyleBackColor = true;
            buttonViewSchedule.Visible = false;
            buttonViewSchedule.Click += buttonViewSchedule_Click;
            // 
            // dataGVUserSchedule
            // 
            dataGVUserSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVUserSchedule.Location = new Point(41, 142);
            dataGVUserSchedule.Name = "dataGVUserSchedule";
            dataGVUserSchedule.Size = new Size(711, 288);
            dataGVUserSchedule.TabIndex = 32;
            dataGVUserSchedule.Visible = false;
            // 
            // GenerateReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGVUserSchedule);
            Controls.Add(buttonViewSchedule);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(generateButton);
            Controls.Add(selectionLabel);
            Controls.Add(actionComboBox);
            Controls.Add(backButton);
            Name = "GenerateReports";
            Text = "Report generator";
            ((System.ComponentModel.ISupportInitialize)dataGVUserSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label selectionLabel;
        private ComboBox actionComboBox;
        private Button generateButton;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Button buttonViewSchedule;
        private DataGridView dataGVUserSchedule;
    }
}