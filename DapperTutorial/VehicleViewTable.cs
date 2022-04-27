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
    public partial class VehicleViewTable : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleViewTable()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            displayVehicleTableListBox.DataSource = vehicles;
            displayVehicleTableListBox.DisplayMember = "FullInfo";
            // displayVehicleTableListBox.DisplayMember = "VehicleModel";
        }

        private void loadVehicleTableButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            vehicles = db.GetVehiclesTable();

            UpdateBinding();
        }

        private void returnMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
