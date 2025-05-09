namespace WGU.C969.SoftwareII.Forms
{
    partial class CalendarView
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
            datePicker = new DateTimePicker();
            appDataGridView = new DataGridView();
            showDateButton = new Button();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)appDataGridView).BeginInit();
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
            // datePicker
            // 
            datePicker.CustomFormat = "  ";
            datePicker.Font = new Font("Segoe UI", 10F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(288, 389);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(115, 25);
            datePicker.TabIndex = 25;
            datePicker.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // appDataGridView
            // 
            appDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appDataGridView.Location = new Point(68, 58);
            appDataGridView.Name = "appDataGridView";
            appDataGridView.Size = new Size(665, 306);
            appDataGridView.TabIndex = 26;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(409, 391);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(190, 23);
            showDateButton.TabIndex = 27;
            showDateButton.Text = "Show appointments for week";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F);
            dateLabel.Location = new Point(204, 393);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(78, 19);
            dateLabel.TabIndex = 28;
            dateLabel.Text = "Select date:";
            dateLabel.Visible = false;
            // 
            // CalendarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateLabel);
            Controls.Add(showDateButton);
            Controls.Add(appDataGridView);
            Controls.Add(datePicker);
            Controls.Add(backButton);
            Name = "CalendarView";
            Text = "Calendar view";
            ((System.ComponentModel.ISupportInitialize)appDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DateTimePicker datePicker;
        private DataGridView appDataGridView;
        private Button showDateButton;
        private Label dateLabel;
    }
}