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
    public partial class VehiclesCreateRecord : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public VehiclesCreateRecord()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            //vehiclesFoundListBox.DataSource = vehicles;
            //vehiclesFoundListBox.DisplayMember = "FullInfo";
        }

        private void inputRecordButton_Click(object sender, EventArgs e)
        {
            if (inputVehicle_IDText.Text != "")
            {
                DataAccess db = new DataAccess();

                db.InsertVehicle(inputVehicle_IDText.Text, inputVehicleMakeText.Text, inputVehicleModelText.Text,
                    inputVehicleTrimText.Text, inputVINText.Text, inputVehicleLicensePlateText.Text);

                inputVehicle_IDText.Text = "";
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
