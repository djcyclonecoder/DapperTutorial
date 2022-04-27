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
    public partial class InvoiceViewSelected : Form
    {

        List<Invoices> invoice = new List<Invoices>();
        public InvoiceViewSelected()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            //dateListBox.DataSource = estimate;
            //dateListBox.DisplayMember = "date";

        }

        private void searchInvoiceButton_Click(object sender, EventArgs e)
        {
            
            if (searchInvoiceIDText.Text != "")
            {
                /*.
                DataAccess db = new DataAccess();

                var zip = db.GetInvoiceZipByID(searchInvoiceIDText.Text);
                zipTextBox.Text = zip;
                
                var state = db.GetInvoiceStateByID(searchInvoiceIDText.Text);
                stateTextBox.Text = state;

                var city = db.GetInvoiceCityByID(searchInvoiceIDText.Text);
                cityTextBox.Text = city;

                var street = db.GetInvoiceStreetByID(searchInvoiceIDText.Text);
                streetTextBox.Text = street;

                var fname = db.GetInvoicefNameByID(searchInvoiceIDText.Text);
                string firstName = fname;

                var lname = db.GetInvoicelNameByID(searchInvoiceIDText.Text);
                string lastName = lname;

                nameTextBox.Text = firstName + " " + lastName;

                var date = db.GetInvoiceDateByID(searchInvoiceIDText.Text);

                DateTime dateAndTime = DateTime.Parse(date);
                String onlyDate = dateAndTime.ToString("MM/dd/yyyy");

                dateTextBox.Text = onlyDate;

                var areaCode = db.GetInvoiceAreaCodeByID(searchInvoiceIDText.Text);

                var phoneNumber = db.GetInvoicePhoneNumberByID(searchInvoiceIDText.Text);

                phoneTextBox.Text = "(" + areaCode + ") " + phoneNumber;

                var workDone = db.GetInvoiceWorkDoneByID(searchInvoiceIDText.Text);
                serviceTextBox.Text = workDone;

                var make = db.GetInvoiceMakeByID(searchInvoiceIDText.Text);
                makeTextBox.Text = make;

                var model = db.GetInvoiceModelByID(searchInvoiceIDText.Text);
                modelTextBox.Text = model;

                var trim = db.GetInvoiceTrimByID(searchInvoiceIDText.Text);
                trimTextBox.Text = trim;

                var plate = db.GetInvoicePlateByID(searchInvoiceIDText.Text);
                plateTextBox.Text = plate;

                var VIN = db.GetInvoiceVINByID(searchInvoiceIDText.Text);
                VINTextBox.Text = VIN;

                var parts = db.GetInvoicePartsByID(searchInvoiceIDText.Text);
                float boogery = float.Parse(parts);
                string booger = boogery.ToString("c2");

                partsTextBox.Text = booger;

                var labor = db.GetInvoiceLaborByID(searchInvoiceIDText.Text);
                float boogery2 = float.Parse(labor);
                string booger2 = boogery2.ToString("c2");

                laborTextBox.Text = booger2;

                var total = db.GetInvoiceTotalByID(searchInvoiceIDText.Text);
                float boogery3 = float.Parse(total);
                string booger3 = boogery3.ToString("c2");

                totalTextBox.Text = booger3;
                */

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

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
