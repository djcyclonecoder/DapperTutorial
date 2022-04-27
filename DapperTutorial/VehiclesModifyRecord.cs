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

    public partial class VehiclesModifyRecord : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public VehiclesModifyRecord()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            vehicleFoundListBox.DataSource = vehicles;
            vehicleFoundListBox.DisplayMember = "FullInfo";

        }



        private void enterVehicleIDButton_Click(object sender, EventArgs e)
        {
            if (inputVehicleIDText.Text != "")
            {
                DataAccess db = new DataAccess();

                vehicles = db.EnterVehicleID(inputVehicleIDText.Text);

                UpdateBinding();
            }
            else
            {
                MessageBox.Show("Data not entered . . .", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void vehicleModifyRecordButton_Click(object sender, EventArgs e)
        {
            if (inputVehicle_IDText.Text != "")
            {
                DataAccess db = new DataAccess();

                db.ModifyVehicle(inputVehicle_IDText.Text, inputVehicleMakeText.Text, inputVehicleModelText.Text,
                    inputVehicleTrimText.Text, inputVINText.Text, inputVehicleLicensePlateText.Text);

                inputVehicleIDText.Text = "";
                inputVehicleMakeText.Text = "";
                inputVehicleModelText.Text = "";
                inputVehicleTrimText.Text = "";
                inputVINText.Text = "";
                inputVehicleLicensePlateText.Text = "";
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
