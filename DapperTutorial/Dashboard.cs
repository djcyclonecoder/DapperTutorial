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
    public partial class Dashboard : Form
    {
        List<Customer> customers = new List<Customer>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            //customersFoundListBox.DataSource = customers;
            //customersFoundListBox.DisplayMember = "FullInfo";
        }

        // ============================================================================
        // CUSTOMER DROPDOWN MENU SELECT ITEMS
        // ============================================================================
        private void viewOneCustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare an object for Customer - View selected Record(s) form
            CustomerSingleRecordForm custSingleRecord = new CustomerSingleRecordForm();
            custSingleRecord.ShowDialog();
        }

        private void viewAllCustomerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare an object for Customer - View All Records
            CustomerDataGridForm custDataGrid = new CustomerDataGridForm();
            custDataGrid.ShowDialog();
        }

        private void createANewCustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCreateRecordForm custCreateRecord = new CustomerCreateRecordForm();
            custCreateRecord.ShowDialog();
        }

        private void deleteACustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDeleteRecord custDeleteRecord = new CustomerDeleteRecord();
            custDeleteRecord.ShowDialog();
        }

        private void modifyAnExistingCustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerModifyRecord custModifyRecord = new CustomerModifyRecord();
            custModifyRecord.ShowDialog();
        }

        // ============================================================================
        // VEHICLE DROPDOWN MENU SELECT ITEMS
        // ============================================================================

        private void viewAllVehicleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleViewTable vehicleViewTable = new VehicleViewTable();
            vehicleViewTable.ShowDialog();
        }

        private void viewOneVehicleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiclesViewSelected vehicleViewSelected = new VehiclesViewSelected();
            vehicleViewSelected.ShowDialog();
        }


        private void createANewVehicleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiclesCreateRecord vehicleCreateRecord = new VehiclesCreateRecord();
            vehicleCreateRecord.ShowDialog();
        }


        private void modifyAnExistingVehicleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiclesModifyRecord vehicleModifyRecord = new VehiclesModifyRecord();
            vehicleModifyRecord.ShowDialog();
        }


        private void deleteAVehicleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleDeleteRecord vehicleDeleteRecord = new VehicleDeleteRecord();
            vehicleDeleteRecord.ShowDialog();
        }


        // ============================================================================
        // EMPLOYEE DROPDOWN MENU SELECT ITEMS
        // ============================================================================

        private void viewAllEmployeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeViewTable employeeViewTable = new EmployeeViewTable();
            employeeViewTable.ShowDialog();
        }


        private void viewSelectedEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeViewSelected employeeViewSelected = new EmployeeViewSelected();
            employeeViewSelected.ShowDialog();
        }


        // ============================================================================
        // ESTIMATE DROPDOWN MENU SELECT ITEMS
        // ============================================================================

        private void viewAllEstimateRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstimateViewTable estimateViewTable = new EstimateViewTable();
            estimateViewTable.ShowDialog();
        }


        private void viewSelectedEstimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstimateViewByID estimateViewSelected = new EstimateViewByID();
            estimateViewSelected.ShowDialog();
        }



        // ============================================================================
        // INVOICE DROPDOWN MENU SELECT ITEMS
        // ============================================================================


        private void viewAllInvoiceRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceViewTable invoiceViewTable = new InvoiceViewTable();
            invoiceViewTable.ShowDialog();
        }


        private void viewSelectedInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceViewSelected invoiceViewSelected = new InvoiceViewSelected();
            invoiceViewSelected.ShowDialog();
        }






        private void quitButton_Click(object sender, EventArgs e)
        {
            // Exit the program on menu option click
            this.Close();
        }







        // =================================================================

        /*
        private void hourlyWageButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            var answer = db.GetHourlyWage(inputEmpIDText.Text);

            answerBox.Text = answer.ToString("0.00");

        }
        */


    }
}
