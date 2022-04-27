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
    public partial class EmployeeViewTable : Form
    {
        List<Employee> employees = new List<Employee>();
        public EmployeeViewTable()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            displayEmployeeTableListBox.DataSource = employees;
            displayEmployeeTableListBox.DisplayMember = "FullInfo";
        }

        private void loadEmployeeTableButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            employees = db.GetEmployeesTable();

            UpdateBinding();
        }

        private void returnMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
