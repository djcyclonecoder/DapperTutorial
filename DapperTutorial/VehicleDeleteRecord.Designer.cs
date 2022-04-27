namespace DapperTutorial
{
    partial class VehicleDeleteRecord
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
            this.quitButton = new System.Windows.Forms.Button();
            this.vehicleDeleteRecordButton = new System.Windows.Forms.Button();
            this.deleteRecordLabel = new System.Windows.Forms.Label();
            this.deleteVehicle_IDText = new System.Windows.Forms.TextBox();
            this.vehicleDeleteRecordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(298, 556);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(162, 94);
            this.quitButton.TabIndex = 29;
            this.quitButton.Text = "Main Menu";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // vehicleDeleteRecordButton
            // 
            this.vehicleDeleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDeleteRecordButton.Location = new System.Drawing.Point(491, 556);
            this.vehicleDeleteRecordButton.Name = "vehicleDeleteRecordButton";
            this.vehicleDeleteRecordButton.Size = new System.Drawing.Size(162, 94);
            this.vehicleDeleteRecordButton.TabIndex = 38;
            this.vehicleDeleteRecordButton.Text = "Delete Vehicle";
            this.vehicleDeleteRecordButton.UseVisualStyleBackColor = true;
            this.vehicleDeleteRecordButton.Click += new System.EventHandler(this.vehicleDeleteRecordButton_Click);
            // 
            // deleteRecordLabel
            // 
            this.deleteRecordLabel.AutoSize = true;
            this.deleteRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordLabel.Location = new System.Drawing.Point(497, 387);
            this.deleteRecordLabel.Name = "deleteRecordLabel";
            this.deleteRecordLabel.Size = new System.Drawing.Size(234, 29);
            this.deleteRecordLabel.TabIndex = 37;
            this.deleteRecordLabel.Text = "Vehicle_ID number";
            // 
            // deleteVehicle_IDText
            // 
            this.deleteVehicle_IDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteVehicle_IDText.Location = new System.Drawing.Point(807, 384);
            this.deleteVehicle_IDText.Name = "deleteVehicle_IDText";
            this.deleteVehicle_IDText.Size = new System.Drawing.Size(264, 34);
            this.deleteVehicle_IDText.TabIndex = 36;
            // 
            // vehicleDeleteRecordLabel
            // 
            this.vehicleDeleteRecordLabel.AutoSize = true;
            this.vehicleDeleteRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDeleteRecordLabel.Location = new System.Drawing.Point(293, 241);
            this.vehicleDeleteRecordLabel.Name = "vehicleDeleteRecordLabel";
            this.vehicleDeleteRecordLabel.Size = new System.Drawing.Size(1468, 58);
            this.vehicleDeleteRecordLabel.TabIndex = 35;
            this.vehicleDeleteRecordLabel.Text = "Enter the appropriate Vehicle_ID number and click the \'Delete Vehicle Record\' but" +
    "ton to remove a Vehicle from the database. \r\nWarning: this process cannot be rev" +
    "ersed.";
            // 
            // VehicleDeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 745);
            this.Controls.Add(this.vehicleDeleteRecordButton);
            this.Controls.Add(this.deleteRecordLabel);
            this.Controls.Add(this.deleteVehicle_IDText);
            this.Controls.Add(this.vehicleDeleteRecordLabel);
            this.Controls.Add(this.quitButton);
            this.Name = "VehicleDeleteRecord";
            this.Text = "VehicleDeleteRecord";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button vehicleDeleteRecordButton;
        private System.Windows.Forms.Label deleteRecordLabel;
        private System.Windows.Forms.TextBox deleteVehicle_IDText;
        private System.Windows.Forms.Label vehicleDeleteRecordLabel;
    }
}