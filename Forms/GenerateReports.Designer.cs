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
            backButton.Click += this.backButton_Click;
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
            actionComboBox.Items.AddRange(new object[] { "Number of appointment types by month", "Schedule for each user", "Additional report" });
            actionComboBox.Location = new Point(345, 41);
            actionComboBox.Name = "actionComboBox";
            actionComboBox.Size = new Size(232, 25);
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
            // 
            // GenerateReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(generateButton);
            Controls.Add(selectionLabel);
            Controls.Add(actionComboBox);
            Controls.Add(backButton);
            Name = "GenerateReports";
            Text = "Report generator";
            Load += this.GenerateReports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label selectionLabel;
        private ComboBox actionComboBox;
        private Button generateButton;
    }
}