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
    public partial class CustomerDeleteRecord : Form
    {
        public CustomerDeleteRecord()
        {
            InitializeComponent();
        }

        private void customerDeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (deleteCustomer_IDText.Text != "")
            {
                DataAccess db = new DataAccess();

                db.DeleteCustomer(deleteCustomer_IDText.Text);

                deleteCustomer_IDText.Text = "";
            }
            else
            {
                MessageBox.Show("Data not entered . . .", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
