using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperTutorial
{
    public partial class VehicleDeleteRecord : Form
    {
        public VehicleDeleteRecord()
        {
            InitializeComponent();
        }



        private void vehicleDeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (deleteVehicle_IDText.Text != "")
            {
                DataAccess db = new DataAccess();

                db.DeleteVehicle(deleteVehicle_IDText.Text);

                deleteVehicle_IDText.Text = "";
            }
            else
            {
                MessageBox.Show("Data not entered . . .", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

            private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
