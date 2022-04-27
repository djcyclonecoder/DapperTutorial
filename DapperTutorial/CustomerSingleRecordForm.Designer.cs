namespace DapperTutorial
{
    partial class CustomerSingleRecordForm
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.customerLastNameText = new System.Windows.Forms.TextBox();
            this.customersFoundListBox = new System.Windows.Forms.ListBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.searchCustomerCityButton = new System.Windows.Forms.Button();
            this.searchByCityLabel = new System.Windows.Forms.Label();
            this.searchCustomerCityText = new System.Windows.Forms.TextBox();
            this.searchCustomerZipCodeButton = new System.Windows.Forms.Button();
            this.searchByZipCodeLabel = new System.Windows.Forms.Label();
            this.searchCustomerZipCodeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(265, 673);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(163, 102);
            this.mainMenuButton.TabIndex = 4;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(414, 281);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 61);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(260, 215);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(137, 29);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // customerLastNameText
            // 
            this.customerLastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameText.Location = new System.Drawing.Point(414, 212);
            this.customerLastNameText.Name = "customerLastNameText";
            this.customerLastNameText.Size = new System.Drawing.Size(264, 34);
            this.customerLastNameText.TabIndex = 6;
            // 
            // customersFoundListBox
            // 
            this.customersFoundListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersFoundListBox.FormattingEnabled = true;
            this.customersFoundListBox.ItemHeight = 29;
            this.customersFoundListBox.Location = new System.Drawing.Point(265, 378);
            this.customersFoundListBox.Name = "customersFoundListBox";
            this.customersFoundListBox.Size = new System.Drawing.Size(1233, 236);
            this.customersFoundListBox.TabIndex = 5;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(260, 153);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(583, 29);
            this.instructionsLabel.TabIndex = 9;
            this.instructionsLabel.Text = "Search for Selected Customer Record(s). Look up by:";
            // 
            // searchCustomerCityButton
            // 
            this.searchCustomerCityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerCityButton.Location = new System.Drawing.Point(887, 281);
            this.searchCustomerCityButton.Name = "searchCustomerCityButton";
            this.searchCustomerCityButton.Size = new System.Drawing.Size(130, 61);
            this.searchCustomerCityButton.TabIndex = 12;
            this.searchCustomerCityButton.Text = "Search";
            this.searchCustomerCityButton.UseVisualStyleBackColor = true;
            this.searchCustomerCityButton.Click += new System.EventHandler(this.searchCustomerCityButton_Click);
            // 
            // searchByCityLabel
            // 
            this.searchByCityLabel.AutoSize = true;
            this.searchByCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCityLabel.Location = new System.Drawing.Point(797, 215);
            this.searchByCityLabel.Name = "searchByCityLabel";
            this.searchByCityLabel.Size = new System.Drawing.Size(57, 29);
            this.searchByCityLabel.TabIndex = 11;
            this.searchByCityLabel.Text = "City";
            // 
            // searchCustomerCityText
            // 
            this.searchCustomerCityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerCityText.Location = new System.Drawing.Point(887, 212);
            this.searchCustomerCityText.Name = "searchCustomerCityText";
            this.searchCustomerCityText.Size = new System.Drawing.Size(264, 34);
            this.searchCustomerCityText.TabIndex = 10;
            // 
            // searchCustomerZipCodeButton
            // 
            this.searchCustomerZipCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerZipCodeButton.Location = new System.Drawing.Point(1382, 284);
            this.searchCustomerZipCodeButton.Name = "searchCustomerZipCodeButton";
            this.searchCustomerZipCodeButton.Size = new System.Drawing.Size(130, 61);
            this.searchCustomerZipCodeButton.TabIndex = 15;
            this.searchCustomerZipCodeButton.Text = "Search";
            this.searchCustomerZipCodeButton.UseVisualStyleBackColor = true;
            this.searchCustomerZipCodeButton.Click += new System.EventHandler(this.searchCustomerZipCodeButton_Click);
            // 
            // searchByZipCodeLabel
            // 
            this.searchByZipCodeLabel.AutoSize = true;
            this.searchByZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByZipCodeLabel.Location = new System.Drawing.Point(1247, 215);
            this.searchByZipCodeLabel.Name = "searchByZipCodeLabel";
            this.searchByZipCodeLabel.Size = new System.Drawing.Size(120, 29);
            this.searchByZipCodeLabel.TabIndex = 14;
            this.searchByZipCodeLabel.Text = "Zip Code";
            // 
            // searchCustomerZipCodeText
            // 
            this.searchCustomerZipCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerZipCodeText.Location = new System.Drawing.Point(1382, 215);
            this.searchCustomerZipCodeText.Name = "searchCustomerZipCodeText";
            this.searchCustomerZipCodeText.Size = new System.Drawing.Size(264, 34);
            this.searchCustomerZipCodeText.TabIndex = 13;
            // 
            // CustomerSingleRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 894);
            this.Controls.Add(this.searchCustomerZipCodeButton);
            this.Controls.Add(this.searchByZipCodeLabel);
            this.Controls.Add(this.searchCustomerZipCodeText);
            this.Controls.Add(this.searchCustomerCityButton);
            this.Controls.Add(this.searchByCityLabel);
            this.Controls.Add(this.searchCustomerCityText);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.customerLastNameText);
            this.Controls.Add(this.customersFoundListBox);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "CustomerSingleRecordForm";
            this.Text = "CustomerSingleRecordForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox customerLastNameText;
        private System.Windows.Forms.ListBox customersFoundListBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button searchCustomerCityButton;
        private System.Windows.Forms.Label searchByCityLabel;
        private System.Windows.Forms.TextBox searchCustomerCityText;
        private System.Windows.Forms.Button searchCustomerZipCodeButton;
        private System.Windows.Forms.Label searchByZipCodeLabel;
        private System.Windows.Forms.TextBox searchCustomerZipCodeText;
    }
}