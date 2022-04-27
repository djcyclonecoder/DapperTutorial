namespace DapperTutorial
{
    partial class EmployeeViewTable
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.loadEmployeeTableButton = new System.Windows.Forms.Button();
            this.displayEmployeeTableListBox = new System.Windows.Forms.ListBox();
            this.returnMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(285, 158);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(1009, 29);
            this.instructionsLabel.TabIndex = 27;
            this.instructionsLabel.Text = "Click on the \'Load Employee Table\' button to see a listing of all employees in th" +
    "e database . . .";
            // 
            // loadEmployeeTableButton
            // 
            this.loadEmployeeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadEmployeeTableButton.Location = new System.Drawing.Point(514, 718);
            this.loadEmployeeTableButton.Name = "loadEmployeeTableButton";
            this.loadEmployeeTableButton.Size = new System.Drawing.Size(156, 100);
            this.loadEmployeeTableButton.TabIndex = 26;
            this.loadEmployeeTableButton.Text = "Load Employee Table";
            this.loadEmployeeTableButton.UseVisualStyleBackColor = true;
            this.loadEmployeeTableButton.Click += new System.EventHandler(this.loadEmployeeTableButton_Click);
            // 
            // displayEmployeeTableListBox
            // 
            this.displayEmployeeTableListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmployeeTableListBox.FormattingEnabled = true;
            this.displayEmployeeTableListBox.ItemHeight = 29;
            this.displayEmployeeTableListBox.Location = new System.Drawing.Point(290, 221);
            this.displayEmployeeTableListBox.Name = "displayEmployeeTableListBox";
            this.displayEmployeeTableListBox.Size = new System.Drawing.Size(1321, 468);
            this.displayEmployeeTableListBox.TabIndex = 25;
            // 
            // returnMainMenuButton
            // 
            this.returnMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenuButton.Location = new System.Drawing.Point(290, 718);
            this.returnMainMenuButton.Name = "returnMainMenuButton";
            this.returnMainMenuButton.Size = new System.Drawing.Size(156, 100);
            this.returnMainMenuButton.TabIndex = 24;
            this.returnMainMenuButton.Text = "Main Menu";
            this.returnMainMenuButton.UseVisualStyleBackColor = true;
            this.returnMainMenuButton.Click += new System.EventHandler(this.returnMainMenuButton_Click);
            // 
            // EmployeeViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 747);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.loadEmployeeTableButton);
            this.Controls.Add(this.displayEmployeeTableListBox);
            this.Controls.Add(this.returnMainMenuButton);
            this.Name = "EmployeeViewTable";
            this.Text = "EmployeeViewTable";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button loadEmployeeTableButton;
        private System.Windows.Forms.ListBox displayEmployeeTableListBox;
        private System.Windows.Forms.Button returnMainMenuButton;
    }
}