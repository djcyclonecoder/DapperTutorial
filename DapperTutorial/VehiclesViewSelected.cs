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
    public partial class VehiclesViewSelected : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public VehiclesViewSelected()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            vehiclesFoundListBox.DataSource = vehicles;
            vehiclesFoundListBox.DisplayMember = "FullInfo";
            // vehiclesFoundListBox.DisplayMember = "VehicleModel";

        }


        private void vehicleSearchMakeButton_Click(object sender, EventArgs e)
        {
            searchVehicleModelText.Text = "";
            licensePlateText.Text = "";

            DataAccess db = new DataAccess();

            vehicles = db.GetVehiclesByMake(vehicleMakeText.Text);

            UpdateBinding();
        }

        private void vehicleSearchModelButton_Click(object sender, EventArgs e)
        {
            vehicleMakeText.Text = "";
            licensePlateText.Text = "";

            DataAccess db = new DataAccess();

            vehicles = db.GetVehiclesByModel(searchVehicleModelText.Text);

            UpdateBinding();

        }

        private void searchLicensePlateButton_Click(object sender, EventArgs e)
        {
            searchVehicleModelText.Text = "";
            vehicleMakeText.Text = "";

            DataAccess db = new DataAccess();

            vehicles = db.GetVehiclesByPlate(licensePlateText.Text);

            UpdateBinding();

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
