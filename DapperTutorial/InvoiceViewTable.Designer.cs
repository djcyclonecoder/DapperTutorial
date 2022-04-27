namespace DapperTutorial
{
    partial class InvoiceViewTable
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.displayInvoiceTableListBox = new System.Windows.Forms.ListBox();
            this.loadInvoiceTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(265, 637);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(156, 100);
            this.quitButton.TabIndex = 29;
            this.quitButton.Text = "Main Menu";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(220, 77);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(945, 29);
            this.instructionsLabel.TabIndex = 33;
            this.instructionsLabel.Text = "Click on the \'Load Invoice Table\' button to see a listing of all invoices in the " +
    "database . . .";
            // 
            // displayInvoiceTableListBox
            // 
            this.displayInvoiceTableListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInvoiceTableListBox.FormattingEnabled = true;
            this.displayInvoiceTableListBox.ItemHeight = 29;
            this.displayInvoiceTableListBox.Location = new System.Drawing.Point(225, 140);
            this.displayInvoiceTableListBox.Name = "displayInvoiceTableListBox";
            this.displayInvoiceTableListBox.Size = new System.Drawing.Size(1321, 468);
            this.displayInvoiceTableListBox.TabIndex = 31;
            // 
            // loadInvoiceTableButton
            // 
            this.loadInvoiceTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadInvoiceTableButton.Location = new System.Drawing.Point(449, 637);
            this.loadInvoiceTableButton.Name = "loadInvoiceTableButton";
            this.loadInvoiceTableButton.Size = new System.Drawing.Size(156, 100);
            this.loadInvoiceTableButton.TabIndex = 32;
            this.loadInvoiceTableButton.Text = "Load Invoice Table";
            this.loadInvoiceTableButton.UseVisualStyleBackColor = true;
            this.loadInvoiceTableButton.Click += new System.EventHandler(this.loadInvoiceTableButton_Click);
            // 
            // InvoiceViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 815);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.loadInvoiceTableButton);
            this.Controls.Add(this.displayInvoiceTableListBox);
            this.Controls.Add(this.quitButton);
            this.Name = "InvoiceViewTable";
            this.Text = "InvoiceViewTable";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.ListBox displayInvoiceTableListBox;
        private System.Windows.Forms.Button loadInvoiceTableButton;
    }
}