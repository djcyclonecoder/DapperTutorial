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
    public partial class InvoiceViewTable : Form
    {
        List<Invoices> invoices = new List<Invoices>();
        public InvoiceViewTable()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            displayInvoiceTableListBox.DataSource = invoices;
            displayInvoiceTableListBox.DisplayMember = "FullInfo";
        }

        private void loadInvoiceTableButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            invoices = db.GetInvoiceTable();

            UpdateBinding();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
