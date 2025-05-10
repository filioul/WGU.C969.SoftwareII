namespace WGU.C969.SoftwareII.Forms
{
    partial class SelectCustomer
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
            selectLabel = new Label();
            customerGridView = new DataGridView();
            selectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            SuspendLayout();
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI", 13F);
            selectLabel.Location = new Point(69, 31);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(246, 25);
            selectLabel.TabIndex = 24;
            selectLabel.Text = "Select a customer to continue";
            // 
            // customerGridView
            // 
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Location = new Point(69, 69);
            customerGridView.Name = "customerGridView";
            customerGridView.Size = new Size(665, 306);
            customerGridView.TabIndex = 27;
            // 
            // selectButton
            // 
            selectButton.Enabled = false;
            selectButton.Font = new Font("Segoe UI", 10F);
            selectButton.Location = new Point(643, 381);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(91, 45);
            selectButton.TabIndex = 28;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectButton);
            Controls.Add(customerGridView);
            Controls.Add(selectLabel);
            Name = "SelectCustomer";
            Text = "SelectCustomer";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectLabel;
        private DataGridView customerGridView;
        private Button selectButton;
    }
}