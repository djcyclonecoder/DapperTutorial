namespace DapperTutorial
{
    partial class VehicleViewTable
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
            this.loadVehicleTableButton = new System.Windows.Forms.Button();
            this.displayVehicleTableListBox = new System.Windows.Forms.ListBox();
            this.returnMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(285, 122);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(949, 29);
            this.instructionsLabel.TabIndex = 23;
            this.instructionsLabel.Text = "Click on the \'Load Vehicle Table\' button to see a listing of all vehicles in the " +
    "database . . .";
            // 
            // loadVehicleTableButton
            // 
            this.loadVehicleTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadVehicleTableButton.Location = new System.Drawing.Point(514, 682);
            this.loadVehicleTableButton.Name = "loadVehicleTableButton";
            this.loadVehicleTableButton.Size = new System.Drawing.Size(156, 100);
            this.loadVehicleTableButton.TabIndex = 22;
            this.loadVehicleTableButton.Text = "Load Vehicle Table";
            this.loadVehicleTableButton.UseVisualStyleBackColor = true;
            this.loadVehicleTableButton.Click += new System.EventHandler(this.loadVehicleTableButton_Click);
            // 
            // displayVehicleTableListBox
            // 
            this.displayVehicleTableListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayVehicleTableListBox.FormattingEnabled = true;
            this.displayVehicleTableListBox.ItemHeight = 29;
            this.displayVehicleTableListBox.Location = new System.Drawing.Point(290, 185);
            this.displayVehicleTableListBox.Name = "displayVehicleTableListBox";
            this.displayVehicleTableListBox.Size = new System.Drawing.Size(1321, 468);
            this.displayVehicleTableListBox.TabIndex = 21;
            // 
            // returnMainMenuButton
            // 
            this.returnMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenuButton.Location = new System.Drawing.Point(290, 682);
            this.returnMainMenuButton.Name = "returnMainMenuButton";
            this.returnMainMenuButton.Size = new System.Drawing.Size(156, 100);
            this.returnMainMenuButton.TabIndex = 20;
            this.returnMainMenuButton.Text = "Main Menu";
            this.returnMainMenuButton.UseVisualStyleBackColor = true;
            this.returnMainMenuButton.Click += new System.EventHandler(this.returnMainMenuButton_Click);
            // 
            // VehicleViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 765);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.loadVehicleTableButton);
            this.Controls.Add(this.displayVehicleTableListBox);
            this.Controls.Add(this.returnMainMenuButton);
            this.Name = "VehicleViewTable";
            this.Text = "VehicleViewTable";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button loadVehicleTableButton;
        private System.Windows.Forms.ListBox displayVehicleTableListBox;
        private System.Windows.Forms.Button returnMainMenuButton;
    }
}