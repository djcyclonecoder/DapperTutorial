namespace DapperTutorial
{
    partial class EmployeeViewSelected
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
            this.jobTitleButton = new System.Windows.Forms.Button();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleText = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.empFirstNameButton = new System.Windows.Forms.Button();
            this.searchEmpFirstNameLabel = new System.Windows.Forms.Label();
            this.empFirstNameText = new System.Windows.Forms.TextBox();
            this.employeesFoundListBox = new System.Windows.Forms.ListBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jobTitleButton
            // 
            this.jobTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleButton.Location = new System.Drawing.Point(1045, 324);
            this.jobTitleButton.Name = "jobTitleButton";
            this.jobTitleButton.Size = new System.Drawing.Size(130, 61);
            this.jobTitleButton.TabIndex = 36;
            this.jobTitleButton.Text = "Search";
            this.jobTitleButton.UseVisualStyleBackColor = true;
            this.jobTitleButton.Click += new System.EventHandler(this.jobTitleButton_Click);
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(904, 255);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(116, 29);
            this.jobTitleLabel.TabIndex = 35;
            this.jobTitleLabel.Text = "Job Title";
            // 
            // jobTitleText
            // 
            this.jobTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleText.Location = new System.Drawing.Point(1045, 253);
            this.jobTitleText.Name = "jobTitleText";
            this.jobTitleText.Size = new System.Drawing.Size(264, 34);
            this.jobTitleText.TabIndex = 34;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(328, 196);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(588, 29);
            this.instructionsLabel.TabIndex = 33;
            this.instructionsLabel.Text = "Search for Selected Employee Record(s). Look up by:";
            // 
            // empFirstNameButton
            // 
            this.empFirstNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFirstNameButton.Location = new System.Drawing.Point(551, 322);
            this.empFirstNameButton.Name = "empFirstNameButton";
            this.empFirstNameButton.Size = new System.Drawing.Size(130, 61);
            this.empFirstNameButton.TabIndex = 32;
            this.empFirstNameButton.Text = "Search";
            this.empFirstNameButton.UseVisualStyleBackColor = true;
            this.empFirstNameButton.Click += new System.EventHandler(this.empFirstNameButton_Click);
            // 
            // searchEmpFirstNameLabel
            // 
            this.searchEmpFirstNameLabel.AutoSize = true;
            this.searchEmpFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmpFirstNameLabel.Location = new System.Drawing.Point(328, 258);
            this.searchEmpFirstNameLabel.Name = "searchEmpFirstNameLabel";
            this.searchEmpFirstNameLabel.Size = new System.Drawing.Size(201, 29);
            this.searchEmpFirstNameLabel.TabIndex = 31;
            this.searchEmpFirstNameLabel.Text = "Emp First Name";
            // 
            // empFirstNameText
            // 
            this.empFirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFirstNameText.Location = new System.Drawing.Point(551, 253);
            this.empFirstNameText.Name = "empFirstNameText";
            this.empFirstNameText.Size = new System.Drawing.Size(264, 34);
            this.empFirstNameText.TabIndex = 30;
            // 
            // employeesFoundListBox
            // 
            this.employeesFoundListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesFoundListBox.FormattingEnabled = true;
            this.employeesFoundListBox.ItemHeight = 29;
            this.employeesFoundListBox.Location = new System.Drawing.Point(333, 418);
            this.employeesFoundListBox.Name = "employeesFoundListBox";
            this.employeesFoundListBox.Size = new System.Drawing.Size(1233, 236);
            this.employeesFoundListBox.TabIndex = 29;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(333, 678);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(163, 102);
            this.mainMenuButton.TabIndex = 28;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // EmployeeViewSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 754);
            this.Controls.Add(this.jobTitleButton);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobTitleText);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.empFirstNameButton);
            this.Controls.Add(this.searchEmpFirstNameLabel);
            this.Controls.Add(this.empFirstNameText);
            this.Controls.Add(this.employeesFoundListBox);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "EmployeeViewSelected";
            this.Text = "EmployeeViewSelected";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button jobTitleButton;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox jobTitleText;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button empFirstNameButton;
        private System.Windows.Forms.Label searchEmpFirstNameLabel;
        private System.Windows.Forms.TextBox empFirstNameText;
        private System.Windows.Forms.ListBox employeesFoundListBox;
        private System.Windows.Forms.Button mainMenuButton;
    }
}