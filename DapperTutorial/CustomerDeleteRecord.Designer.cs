namespace DapperTutorial
{
    partial class CustomerDeleteRecord
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
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.customerDeleteRecordLabel = new System.Windows.Forms.Label();
            this.deleteRecordLabel = new System.Windows.Forms.Label();
            this.deleteCustomer_IDText = new System.Windows.Forms.TextBox();
            this.customerDeleteRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(234, 525);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(162, 94);
            this.returnToMainMenuButton.TabIndex = 29;
            this.returnToMainMenuButton.Text = "Main Menu";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // customerDeleteRecordLabel
            // 
            this.customerDeleteRecordLabel.AutoSize = true;
            this.customerDeleteRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDeleteRecordLabel.Location = new System.Drawing.Point(229, 210);
            this.customerDeleteRecordLabel.Name = "customerDeleteRecordLabel";
            this.customerDeleteRecordLabel.Size = new System.Drawing.Size(1424, 58);
            this.customerDeleteRecordLabel.TabIndex = 30;
            this.customerDeleteRecordLabel.Text = "Enter the appropriate Customer_ID number and click the \'Delete Record\' button to " +
    "remove a Customer from the database. \r\nWarning: this process cannot be reversed." +
    "";
            // 
            // deleteRecordLabel
            // 
            this.deleteRecordLabel.AutoSize = true;
            this.deleteRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordLabel.Location = new System.Drawing.Point(543, 400);
            this.deleteRecordLabel.Name = "deleteRecordLabel";
            this.deleteRecordLabel.Size = new System.Drawing.Size(259, 29);
            this.deleteRecordLabel.TabIndex = 32;
            this.deleteRecordLabel.Text = "Customer_ID number";
            // 
            // deleteCustomer_IDText
            // 
            this.deleteCustomer_IDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer_IDText.Location = new System.Drawing.Point(853, 397);
            this.deleteCustomer_IDText.Name = "deleteCustomer_IDText";
            this.deleteCustomer_IDText.Size = new System.Drawing.Size(264, 34);
            this.deleteCustomer_IDText.TabIndex = 31;
            // 
            // customerDeleteRecordButton
            // 
            this.customerDeleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDeleteRecordButton.Location = new System.Drawing.Point(427, 525);
            this.customerDeleteRecordButton.Name = "customerDeleteRecordButton";
            this.customerDeleteRecordButton.Size = new System.Drawing.Size(162, 94);
            this.customerDeleteRecordButton.TabIndex = 33;
            this.customerDeleteRecordButton.Text = "Delete Customer";
            this.customerDeleteRecordButton.UseVisualStyleBackColor = true;
            this.customerDeleteRecordButton.Click += new System.EventHandler(this.customerDeleteRecordButton_Click);
            // 
            // CustomerDeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 775);
            this.Controls.Add(this.customerDeleteRecordButton);
            this.Controls.Add(this.deleteRecordLabel);
            this.Controls.Add(this.deleteCustomer_IDText);
            this.Controls.Add(this.customerDeleteRecordLabel);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Name = "CustomerDeleteRecord";
            this.Text = "CustomerDeleteRecord";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Label customerDeleteRecordLabel;
        private System.Windows.Forms.Label deleteRecordLabel;
        private System.Windows.Forms.TextBox deleteCustomer_IDText;
        private System.Windows.Forms.Button customerDeleteRecordButton;
    }
}