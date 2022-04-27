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
    public partial class CustomerModifyRecord : Form
    {
        List<Customer> customers = new List<Customer>();
        public CustomerModifyRecord()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            customersFoundListBox.DataSource = customers;
            customersFoundListBox.DisplayMember = "FullInfo";

        }


        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterCustomerIDButton_Click(object sender, EventArgs e)
        {
            if (customerIDText.Text != "")
            {
                DataAccess db = new DataAccess();

                customers = db.EnterID(customerIDText.Text);

                UpdateBinding();
            }
            else
            {
                MessageBox.Show("Data not entered . . .", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void customerModifyRecordButton_Click(object sender, EventArgs e)
        {
            if (inputCustomer_IDText.Text != "")
            {
                DataAccess db = new DataAccess();

                db.ModifyCustomer(inputCustomer_IDText.Text, inputCustomerFirstNameText.Text, inputCustomerLastNameText.Text,
                    inputCustomerStreetAddressText.Text, inputCustomerCityText.Text, inputCustomerStateText.Text,
                    inputCustomerZipCodeText.Text, inputCustomerPhoneAreaCodeText.Text, inputCustomerPhoneNumberText.Text);

                inputCustomer_IDText.Text = "";
                inputCustomerFirstNameText.Text = "";
                inputCustomerLastNameText.Text = "";
                inputCustomerStreetAddressText.Text = "";
                inputCustomerCityText.Text = "";
                inputCustomerStateText.Text = "";
                inputCustomerZipCodeText.Text = "";
                inputCustomerPhoneAreaCodeText.Text = "";
                inputCustomerPhoneNumberText.Text = "";
            }
            else
            {
                MessageBox.Show("Data not entered . . .", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
