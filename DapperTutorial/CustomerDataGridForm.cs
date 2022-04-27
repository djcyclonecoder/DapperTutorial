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
    public partial class CustomerDataGridForm : Form
    {
        List<Customer> customers = new List<Customer>();
        public CustomerDataGridForm()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            displayCustomerTableListBox.DataSource = customers;
            displayCustomerTableListBox.DisplayMember = "FullInfo";
        }

        private void returnMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadCustomerTableButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customers = db.GetCustomersTable2();

            UpdateBinding();
        }
    }
}
