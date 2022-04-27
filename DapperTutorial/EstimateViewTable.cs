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
    public partial class EstimateViewTable : Form
    {
        List<Estimates> estimates = new List<Estimates>();
        public EstimateViewTable()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            displayEstimatesTableListBox.DataSource = estimates;
            displayEstimatesTableListBox.DisplayMember = "FullInfo";
        }


        private void loadEstimateTableButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            estimates = db.GetEstimateTable();

            UpdateBinding();

            loadEstimateButton.Visible = true;
        }


        private void loadEstimateButton_Click(object sender, EventArgs e)
        {
            int value = 4001 + displayEstimatesTableListBox.SelectedIndex;

            string estID = value.ToString();

            estimateNumberTextBox.Text = estID;

            instructionsLabel.Visible = false;
            displayEstimatesTableListBox.Visible = false;
            loadEstimateButton.Visible = false;
            loadEstimateTableButton.Visible = false;
            quitButton.Visible = false;

            backButton.Visible = true;

            pictureBox1.Visible = true;
            estimateHeaderLabel.Visible = true;
            vehicleInfoLabel.Visible = true;
            serviceDescriptionLabel.Visible = true;
            customerLabel.Visible = true;
            costLabel.Visible = true;

            dateLabel.Visible = true;
            dateTextBox.Visible = true;
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            addressLabel.Visible = true;
            streetTextBox.Visible = true;
            cityLabel.Visible = true;
            cityTextBox.Visible = true;
            stateLabel.Visible = true;
            stateTextBox.Visible = true;
            zipCodeLabel.Visible = true;
            zipTextBox.Visible = true;
            phoneLabel.Visible = true;
            phoneTextBox.Visible = true;
            partsLabel.Visible = true;
            partsTextBox.Visible = true;
            laborLabel.Visible = true;
            laborTextBox.Visible = true;
            totalLabel.Visible = true;
            totalTextBox.Visible = true;
            serviceTextBox.Visible = true;
            vehicleMakeLabel.Visible = true;
            makeTextBox.Visible = true;
            vehicleModelLabel.Visible = true;
            modelTextBox.Visible = true;
            vehicleTrimLabel.Visible = true;
            trimTextBox.Visible = true;
            licenseLabel.Visible = true;
            plateTextBox.Visible = true;
            vINLabel.Visible = true;
            VINTextBox.Visible = true;
            estimateNumberLabel.Visible = true;
            estimateNumberTextBox.Visible = true;

            DataAccess db = new DataAccess();

            var zip = db.GetEstimateZipByID(estID);
            zipTextBox.Text = zip.ToString();

            var state = db.GetEstimateStateByID(estID);
            stateTextBox.Text = state;

            var city = db.GetEstimateCityByID(estID);
            cityTextBox.Text = city;

            var street = db.GetEstimateStreetByID(estID);
            streetTextBox.Text = street;

            var fname = db.GetEstimatefNameByID(estID);
            string firstName = fname;

            var lname = db.GetEstimatelNameByID(estID);
            string lastName = lname;

            nameTextBox.Text = firstName + " " + lastName;

            var date = db.GetEstimateDateByID(estID);

            DateTime dateAndTime = DateTime.Parse(date);
            String onlyDate = dateAndTime.ToString("MM/dd/yyyy");

            dateTextBox.Text = onlyDate;

            var areaCode = db.GetEstimateAreaCodeByID(estID);

            var phoneNumber = db.GetEstimatePhoneNumberByID(estID);

            phoneTextBox.Text = "(" + areaCode + ") " + phoneNumber;

            var service = db.GetEstimateServiceByID(estID);
            serviceTextBox.Text = service;

            var make = db.GetEstimateMakeByID(estID);
            makeTextBox.Text = make;

            var model = db.GetEstimateModelByID(estID);
            modelTextBox.Text = model;

            var trim = db.GetEstimateTrimByID(estID);
            trimTextBox.Text = trim;

            var plate = db.GetEstimatePlateByID(estID);
            plateTextBox.Text = plate;

            var VIN = db.GetEstimateVINByID(estID);
            VINTextBox.Text = VIN;

            var parts = db.GetEstimatePartsByID(estID);
            float boogery = float.Parse(parts);
            string booger = boogery.ToString("c2");

            partsTextBox.Text = booger;

            var labor = db.GetEstimateLaborByID(estID);
            float boogery2 = float.Parse(labor);
            string booger2 = boogery2.ToString("c2");

            laborTextBox.Text = booger2;

            var total = db.GetEstimateTotalByID(estID);
            float boogery3 = float.Parse(total);
            string booger3 = boogery3.ToString("c2");

            totalTextBox.Text = booger3;



        }


        private void backButton_Click(object sender, EventArgs e)
        {
            instructionsLabel.Visible = true;
            displayEstimatesTableListBox.Visible = true;
            loadEstimateButton.Visible = true;
            loadEstimateTableButton.Visible = true;
            quitButton.Visible = true;

            backButton.Visible = false;

            pictureBox1.Visible = false;
            estimateHeaderLabel.Visible = false;
            vehicleInfoLabel.Visible = false;
            serviceDescriptionLabel.Visible = false;
            customerLabel.Visible = false;
            costLabel.Visible = false;

            dateLabel.Visible = false;
            dateTextBox.Visible = false;
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            addressLabel.Visible = false;
            streetTextBox.Visible = false;
            cityLabel.Visible = false;
            cityTextBox.Visible = false;
            stateLabel.Visible = false;
            stateTextBox.Visible = false;
            zipCodeLabel.Visible = false;
            zipTextBox.Visible = false;
            phoneLabel.Visible = false;
            phoneTextBox.Visible = false;
            partsLabel.Visible = false;
            partsTextBox.Visible = false;
            laborLabel.Visible = false;
            laborTextBox.Visible = false;
            totalLabel.Visible = false;
            totalTextBox.Visible = false;
            serviceTextBox.Visible = false;
            vehicleMakeLabel.Visible = false;
            makeTextBox.Visible = false;
            vehicleModelLabel.Visible = false;
            modelTextBox.Visible = false;
            vehicleTrimLabel.Visible = false;
            trimTextBox.Visible = false;
            licenseLabel.Visible = false;
            plateTextBox.Visible = false;
            vINLabel.Visible = false;
            VINTextBox.Visible = false;
            estimateNumberLabel.Visible = false;
            estimateNumberTextBox.Visible = false;


        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void invoiceNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
