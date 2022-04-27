namespace DapperTutorial
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOneCustomerRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewCustomerRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAnExistingCustomerRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteACustomerRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllVehicleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOneVehicleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewVehicleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAnExistingVehicleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAVehicleRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSelectedEmployeeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEstimateRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSelectedEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAnExistingEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllInvoiceRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSelectedInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAnExistingInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.estimatesToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.otherReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1508, 40);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllCustomerDataToolStripMenuItem,
            this.viewOneCustomerRecordToolStripMenuItem,
            this.createANewCustomerRecordToolStripMenuItem,
            this.modifyAnExistingCustomerRecordToolStripMenuItem,
            this.deleteACustomerRecordToolStripMenuItem});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // viewAllCustomerDataToolStripMenuItem
            // 
            this.viewAllCustomerDataToolStripMenuItem.Name = "viewAllCustomerDataToolStripMenuItem";
            this.viewAllCustomerDataToolStripMenuItem.Size = new System.Drawing.Size(490, 36);
            this.viewAllCustomerDataToolStripMenuItem.Text = "View all Customer Data";
            this.viewAllCustomerDataToolStripMenuItem.Click += new System.EventHandler(this.viewAllCustomerDataToolStripMenuItem_Click);
            // 
            // viewOneCustomerRecordToolStripMenuItem
            // 
            this.viewOneCustomerRecordToolStripMenuItem.Name = "viewOneCustomerRecordToolStripMenuItem";
            this.viewOneCustomerRecordToolStripMenuItem.Size = new System.Drawing.Size(490, 36);
            this.viewOneCustomerRecordToolStripMenuItem.Text = "View Selected Customer Record(s)";
            this.viewOneCustomerRecordToolStripMenuItem.Click += new System.EventHandler(this.viewOneCustomerRecordToolStripMenuItem_Click);
            // 
            // createANewCustomerRecordToolStripMenuItem
            // 
            this.createANewCustomerRecordToolStripMenuItem.Name = "createANewCustomerRecordToolStripMenuItem";
            this.createANewCustomerRecordToolStripMenuItem.Size = new System.Drawing.Size(490, 36);
            this.createANewCustomerRecordToolStripMenuItem.Text = "Create a new Customer Record";
            this.createANewCustomerRecordToolStripMenuItem.Click += new System.EventHandler(this.createANewCustomerRecordToolStripMenuItem_Click);
            // 
            // modifyAnExistingCustomerRecordToolStripMenuItem
            // 
            this.modifyAnExistingCustomerRecordToolStripMenuItem.Name = "modifyAnExistingCustomerRecordToolStripMenuItem";
            this.modifyAnExistingCustomerRecordToolStripMenuItem.Size = new System.Drawing.Size(490, 36);
            this.modifyAnExistingCustomerRecordToolStripMenuItem.Text = "Modify an existing Customer Record";
            this.modifyAnExistingCustomerRecordToolStripMenuItem.Click += new System.EventHandler(this.modifyAnExistingCustomerRecordToolStripMenuItem_Click);
            // 
            // deleteACustomerRecordToolStripMenuItem
            // 
            this.deleteACustomerRecordToolStripMenuItem.Name = "deleteACustomerRecordToolStripMenuItem";
            this.deleteACustomerRecordToolStripMenuItem.Size = new System.Drawing.Size(490, 36);
            this.deleteACustomerRecordToolStripMenuItem.Text = "Delete a Customer Record";
            this.deleteACustomerRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteACustomerRecordToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllVehicleDataToolStripMenuItem,
            this.viewOneVehicleRecordToolStripMenuItem,
            this.createANewVehicleRecordToolStripMenuItem,
            this.modifyAnExistingVehicleRecordToolStripMenuItem,
            this.deleteAVehicleRecordToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // viewAllVehicleDataToolStripMenuItem
            // 
            this.viewAllVehicleDataToolStripMenuItem.Name = "viewAllVehicleDataToolStripMenuItem";
            this.viewAllVehicleDataToolStripMenuItem.Size = new System.Drawing.Size(462, 36);
            this.viewAllVehicleDataToolStripMenuItem.Text = "View all Vehicle Data";
            this.viewAllVehicleDataToolStripMenuItem.Click += new System.EventHandler(this.viewAllVehicleDataToolStripMenuItem_Click);
            // 
            // viewOneVehicleRecordToolStripMenuItem
            // 
            this.viewOneVehicleRecordToolStripMenuItem.Name = "viewOneVehicleRecordToolStripMenuItem";
            this.viewOneVehicleRecordToolStripMenuItem.Size = new System.Drawing.Size(462, 36);
            this.viewOneVehicleRecordToolStripMenuItem.Text = "View Selected Vehicle Record(s)";
            this.viewOneVehicleRecordToolStripMenuItem.Click += new System.EventHandler(this.viewOneVehicleRecordToolStripMenuItem_Click);
            // 
            // createANewVehicleRecordToolStripMenuItem
            // 
            this.createANewVehicleRecordToolStripMenuItem.Name = "createANewVehicleRecordToolStripMenuItem";
            this.createANewVehicleRecordToolStripMenuItem.Size = new System.Drawing.Size(462, 36);
            this.createANewVehicleRecordToolStripMenuItem.Text = "Create a New Vehicle Record";
            this.createANewVehicleRecordToolStripMenuItem.Click += new System.EventHandler(this.createANewVehicleRecordToolStripMenuItem_Click);
            // 
            // modifyAnExistingVehicleRecordToolStripMenuItem
            // 
            this.modifyAnExistingVehicleRecordToolStripMenuItem.Name = "modifyAnExistingVehicleRecordToolStripMenuItem";
            this.modifyAnExistingVehicleRecordToolStripMenuItem.Size = new System.Drawing.Size(462, 36);
            this.modifyAnExistingVehicleRecordToolStripMenuItem.Text = "Modify an Existing Vehicle Record";
            this.modifyAnExistingVehicleRecordToolStripMenuItem.Click += new System.EventHandler(this.modifyAnExistingVehicleRecordToolStripMenuItem_Click);
            // 
            // deleteAVehicleRecordToolStripMenuItem
            // 
            this.deleteAVehicleRecordToolStripMenuItem.Name = "deleteAVehicleRecordToolStripMenuItem";
            this.deleteAVehicleRecordToolStripMenuItem.Size = new System.Drawing.Size(462, 36);
            this.deleteAVehicleRecordToolStripMenuItem.Text = "Delete a Vehicle Record";
            this.deleteAVehicleRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteAVehicleRecordToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllEmployeeDataToolStripMenuItem,
            this.viewSelectedEmployeeRecordToolStripMenuItem});
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // viewAllEmployeeDataToolStripMenuItem
            // 
            this.viewAllEmployeeDataToolStripMenuItem.Name = "viewAllEmployeeDataToolStripMenuItem";
            this.viewAllEmployeeDataToolStripMenuItem.Size = new System.Drawing.Size(443, 36);
            this.viewAllEmployeeDataToolStripMenuItem.Text = "View all Employee Data";
            this.viewAllEmployeeDataToolStripMenuItem.Click += new System.EventHandler(this.viewAllEmployeeDataToolStripMenuItem_Click);
            // 
            // viewSelectedEmployeeRecordToolStripMenuItem
            // 
            this.viewSelectedEmployeeRecordToolStripMenuItem.Name = "viewSelectedEmployeeRecordToolStripMenuItem";
            this.viewSelectedEmployeeRecordToolStripMenuItem.Size = new System.Drawing.Size(443, 36);
            this.viewSelectedEmployeeRecordToolStripMenuItem.Text = "View Selected Employee Record";
            this.viewSelectedEmployeeRecordToolStripMenuItem.Click += new System.EventHandler(this.viewSelectedEmployeeRecordToolStripMenuItem_Click);
            // 
            // estimatesToolStripMenuItem
            // 
            this.estimatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllEstimateRecordsToolStripMenuItem,
            this.viewSelectedEstimateToolStripMenuItem,
            this.createANewEstimateToolStripMenuItem,
            this.modifyAnExistingEstimateToolStripMenuItem,
            this.deleteAnEstimateToolStripMenuItem});
            this.estimatesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.estimatesToolStripMenuItem.Name = "estimatesToolStripMenuItem";
            this.estimatesToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.estimatesToolStripMenuItem.Text = "Estimates";
            // 
            // viewAllEstimateRecordsToolStripMenuItem
            // 
            this.viewAllEstimateRecordsToolStripMenuItem.Name = "viewAllEstimateRecordsToolStripMenuItem";
            this.viewAllEstimateRecordsToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.viewAllEstimateRecordsToolStripMenuItem.Text = "View all Estimate Records";
            this.viewAllEstimateRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewAllEstimateRecordsToolStripMenuItem_Click);
            // 
            // viewSelectedEstimateToolStripMenuItem
            // 
            this.viewSelectedEstimateToolStripMenuItem.Name = "viewSelectedEstimateToolStripMenuItem";
            this.viewSelectedEstimateToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.viewSelectedEstimateToolStripMenuItem.Text = "View Selected Estimate";
            this.viewSelectedEstimateToolStripMenuItem.Click += new System.EventHandler(this.viewSelectedEstimateToolStripMenuItem_Click);
            // 
            // createANewEstimateToolStripMenuItem
            // 
            this.createANewEstimateToolStripMenuItem.Name = "createANewEstimateToolStripMenuItem";
            this.createANewEstimateToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.createANewEstimateToolStripMenuItem.Text = "Create a New Estimate";
            // 
            // modifyAnExistingEstimateToolStripMenuItem
            // 
            this.modifyAnExistingEstimateToolStripMenuItem.Name = "modifyAnExistingEstimateToolStripMenuItem";
            this.modifyAnExistingEstimateToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.modifyAnExistingEstimateToolStripMenuItem.Text = "Modify an Existing Estimate";
            // 
            // deleteAnEstimateToolStripMenuItem
            // 
            this.deleteAnEstimateToolStripMenuItem.Name = "deleteAnEstimateToolStripMenuItem";
            this.deleteAnEstimateToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.deleteAnEstimateToolStripMenuItem.Text = "Delete an Estimate";
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllInvoiceRecordsToolStripMenuItem,
            this.viewSelectedInvoiceToolStripMenuItem,
            this.createANewInvoiceToolStripMenuItem,
            this.modifyAnExistingInvoiceToolStripMenuItem,
            this.deleteAnInvoiceToolStripMenuItem});
            this.invoicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // viewAllInvoiceRecordsToolStripMenuItem
            // 
            this.viewAllInvoiceRecordsToolStripMenuItem.Name = "viewAllInvoiceRecordsToolStripMenuItem";
            this.viewAllInvoiceRecordsToolStripMenuItem.Size = new System.Drawing.Size(382, 36);
            this.viewAllInvoiceRecordsToolStripMenuItem.Text = "View all Invoice Records";
            this.viewAllInvoiceRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewAllInvoiceRecordsToolStripMenuItem_Click);
            // 
            // viewSelectedInvoiceToolStripMenuItem
            // 
            this.viewSelectedInvoiceToolStripMenuItem.Name = "viewSelectedInvoiceToolStripMenuItem";
            this.viewSelectedInvoiceToolStripMenuItem.Size = new System.Drawing.Size(382, 36);
            this.viewSelectedInvoiceToolStripMenuItem.Text = "View Selected Invoice";
            this.viewSelectedInvoiceToolStripMenuItem.Click += new System.EventHandler(this.viewSelectedInvoiceToolStripMenuItem_Click);
            // 
            // createANewInvoiceToolStripMenuItem
            // 
            this.createANewInvoiceToolStripMenuItem.Name = "createANewInvoiceToolStripMenuItem";
            this.createANewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(382, 36);
            this.createANewInvoiceToolStripMenuItem.Text = "Create a New Invoice";
            // 
            // modifyAnExistingInvoiceToolStripMenuItem
            // 
            this.modifyAnExistingInvoiceToolStripMenuItem.Name = "modifyAnExistingInvoiceToolStripMenuItem";
            this.modifyAnExistingInvoiceToolStripMenuItem.Size = new System.Drawing.Size(382, 36);
            this.modifyAnExistingInvoiceToolStripMenuItem.Text = "Modify an Existing Invoice";
            // 
            // deleteAnInvoiceToolStripMenuItem
            // 
            this.deleteAnInvoiceToolStripMenuItem.Name = "deleteAnInvoiceToolStripMenuItem";
            this.deleteAnInvoiceToolStripMenuItem.Size = new System.Drawing.Size(382, 36);
            this.deleteAnInvoiceToolStripMenuItem.Text = "Delete an Invoice";
            // 
            // otherReportsToolStripMenuItem
            // 
            this.otherReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.otherReportsToolStripMenuItem.Name = "otherReportsToolStripMenuItem";
            this.otherReportsToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.otherReportsToolStripMenuItem.Text = "Other Reports";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(38, 704);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 61);
            this.quitButton.TabIndex = 28;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DapperTutorial.Properties.Resources.chain_wheel_tire;
            this.pictureBox1.Location = new System.Drawing.Point(12, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(327, 248);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(662, 91);
            this.headerLabel.TabIndex = 30;
            this.headerLabel.Text = "Mary\'s Auto Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1209, 91);
            this.label1.TabIndex = 31;
            this.label1.Text = "Digital Estimating/Invoice System";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Mary\'s Auto Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOneCustomerRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewCustomerRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAnExistingCustomerRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteACustomerRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllVehicleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOneVehicleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewVehicleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAnExistingVehicleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAVehicleRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedEmployeeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEstimateRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAnExistingEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllInvoiceRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAnExistingInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherReportsToolStripMenuItem;
        
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label1;
    }
}

