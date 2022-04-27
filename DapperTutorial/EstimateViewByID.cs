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

    public partial class EstimateViewByID : Form
    {
        List<Estimates> estimate = new List<Estimates>();

        public EstimateViewByID()
        {
            InitializeComponent();

            UpdateBinding();
        }


        private void UpdateBinding()
        {
            //dateListBox.DataSource = estimate;
            //dateListBox.DisplayMember = "date";

        }

        private void searchEstimateButton_Click_1(object sender, EventArgs e)
        {
            if (searchEstimateIDText.Text != "")
            {
                DataAccess db = new DataAccess();

                var zip = db.GetEstimateZipByID(searchEstimateIDText.Text);
                zipTextBox.Text = zip.ToString();

                var state = db.GetEstimateStateByID(searchEstimateIDText.Text);
                stateTextBox.Text = state;

                var city = db.GetEstimateCityByID(searchEstimateIDText.Text);
                cityTextBox.Text = city;

                var street = db.GetEstimateStreetByID(searchEstimateIDText.Text);
                streetTextBox.Text = street;

                var fname = db.GetEstimatefNameByID(searchEstimateIDText.Text);
                string firstName = fname;

                var lname = db.GetEstimatelNameByID(searchEstimateIDText.Text);
                string lastName = lname;

                nameTextBox.Text = firstName + " " + lastName;

                var date = db.GetEstimateDateByID(searchEstimateIDText.Text);

                DateTime dateAndTime = DateTime.Parse(date);
                String onlyDate = dateAndTime.ToString("MM/dd/yyyy");

                dateTextBox.Text = onlyDate;

                var areaCode = db.GetEstimateAreaCodeByID(searchEstimateIDText.Text);

                var phoneNumber = db.GetEstimatePhoneNumberByID(searchEstimateIDText.Text);

                phoneTextBox.Text = "(" + areaCode + ") " + phoneNumber;

                var service = db.GetEstimateServiceByID(searchEstimateIDText.Text);
                serviceTextBox.Text = service;

                var make = db.GetEstimateMakeByID(searchEstimateIDText.Text);
                makeTextBox.Text = make;

                var model = db.GetEstimateModelByID(searchEstimateIDText.Text);
                modelTextBox.Text = model;

                var trim = db.GetEstimateTrimByID(searchEstimateIDText.Text);
                trimTextBox.Text = trim;

                var plate = db.GetEstimatePlateByID(searchEstimateIDText.Text);
                plateTextBox.Text = plate;

                var VIN = db.GetEstimateVINByID(searchEstimateIDText.Text);
                VINTextBox.Text = VIN;

                var parts = db.GetEstimatePartsByID(searchEstimateIDText.Text);
                float boogery = float.Parse(parts);
                string booger = boogery.ToString("c2");

                partsTextBox.Text = booger;

                var labor = db.GetEstimateLaborByID(searchEstimateIDText.Text);
                float boogery2 = float.Parse(labor);
                string booger2 = boogery2.ToString("c2");

                laborTextBox.Text = booger2;

                var total = db.GetEstimateTotalByID(searchEstimateIDText.Text);
                float boogery3 = float.Parse(total);
                string booger3 = boogery3.ToString("c2");

                totalTextBox.Text = booger3;




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


