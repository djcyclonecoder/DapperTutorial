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
    public partial class EmployeeViewSelected : Form
    {
        List<Employee> employees = new List<Employee>();
        public EmployeeViewSelected()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            employeesFoundListBox.DataSource = employees;
            employeesFoundListBox.DisplayMember = "FullInfo";
        }


        private void empFirstNameButton_Click(object sender, EventArgs e)
        {
            jobTitleText.Text = "";

            DataAccess db = new DataAccess();

            employees = db.GetEmployeesByFirstName(empFirstNameText.Text);

            UpdateBinding();
        }

        private void jobTitleButton_Click(object sender, EventArgs e)
        {
            empFirstNameText.Text = "";

            DataAccess db = new DataAccess();

            employees = db.GetEmployeesByJobTitle(jobTitleText.Text);

            UpdateBinding();
        }


        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
