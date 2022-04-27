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
    public partial class EstimateViewSelected : Form
    {
        List<Estimates> estimate = new List<Estimates>();
        public EstimateViewSelected()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            dateListBox.DataSource = estimate;
            dateListBox.DisplayMember = "Date";
        }


        private void searchEstimateButton_Click(object sender, EventArgs e)
        {
            if (searchEstimateIDText.Text != "")
            {
                DataAccess db = new DataAccess();

                estimate = db.GetEstimateByID(searchEstimateIDText.Text);

                UpdateBinding();
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
