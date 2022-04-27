namespace DapperTutorial
{
    partial class CustomerDataGridForm
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
            this.returnMainMenuButton = new System.Windows.Forms.Button();
            this.displayCustomerTableListBox = new System.Windows.Forms.ListBox();
            this.loadCustomerTableButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnMainMenuButton
            // 
            this.returnMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenuButton.Location = new System.Drawing.Point(275, 670);
            this.returnMainMenuButton.Name = "returnMainMenuButton";
            this.returnMainMenuButton.Size = new System.Drawing.Size(156, 100);
            this.returnMainMenuButton.TabIndex = 16;
            this.returnMainMenuButton.Text = "Main Menu";
            this.returnMainMenuButton.UseVisualStyleBackColor = true;
            this.returnMainMenuButton.Click += new System.EventHandler(this.returnMainMenuButton_Click);
            // 
            // displayCustomerTableListBox
            // 
            this.displayCustomerTableListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCustomerTableListBox.FormattingEnabled = true;
            this.displayCustomerTableListBox.ItemHeight = 29;
            this.displayCustomerTableListBox.Location = new System.Drawing.Point(275, 173);
            this.displayCustomerTableListBox.Name = "displayCustomerTableListBox";
            this.displayCustomerTableListBox.Size = new System.Drawing.Size(1321, 468);
            this.displayCustomerTableListBox.TabIndex = 17;
            // 
            // loadCustomerTableButton
            // 
            this.loadCustomerTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCustomerTableButton.Location = new System.Drawing.Point(499, 670);
            this.loadCustomerTableButton.Name = "loadCustomerTableButton";
            this.loadCustomerTableButton.Size = new System.Drawing.Size(156, 100);
            this.loadCustomerTableButton.TabIndex = 18;
            this.loadCustomerTableButton.Text = "Load Customer Table";
            this.loadCustomerTableButton.UseVisualStyleBackColor = true;
            this.loadCustomerTableButton.Click += new System.EventHandler(this.loadCustomerTableButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(270, 110);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(996, 29);
            this.instructionsLabel.TabIndex = 19;
            this.instructionsLabel.Text = "Click on the \'Load Customer Table\' button to see a listing of all customers in th" +
    "e database . . .";
            // 
            // CustomerDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 895);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.loadCustomerTableButton);
            this.Controls.Add(this.displayCustomerTableListBox);
            this.Controls.Add(this.returnMainMenuButton);
            this.Name = "CustomerDataGridForm";
            this.Text = "CustomerDataGridForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenuButton;
        private System.Windows.Forms.ListBox displayCustomerTableListBox;
        private System.Windows.Forms.Button loadCustomerTableButton;
        private System.Windows.Forms.Label instructionsLabel;
    }
}