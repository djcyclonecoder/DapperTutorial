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
    public partial class CustomerSingleRecordForm : Form
    {
        List<Customer> customers = new List<Customer>();
        public CustomerSingleRecordForm()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            customersFoundListBox.DataSource = customers;
            customersFoundListBox.DisplayMember = "FullInfo";
        }


        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            // Button to return to Dashboard form
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
                searchCustomerCityText.Text = "";
                searchCustomerZipCodeText.Text = "";

                DataAccess db = new DataAccess();

                customers = db.GetCustomers(customerLastNameText.Text);

                UpdateBinding();

        }

        private void searchCustomerCityButton_Click(object sender, EventArgs e)
        {
            searchCustomerZipCodeText.Text = "";
            customerLastNameText.Text = "";

            DataAccess db = new DataAccess();

            customers = db.GetCustomersByCity(searchCustomerCityText.Text);

            UpdateBinding();
        }

        private void searchCustomerZipCodeButton_Click(object sender, EventArgs e)
        {
            searchCustomerCityText.Text = "";
            customerLastNameText.Text = "";

            DataAccess db = new DataAccess();

            customers = db.GetCustomersByZip(searchCustomerZipCodeText.Text);

            UpdateBinding();
        }
    }
}
