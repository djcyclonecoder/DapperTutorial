using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace DapperTutorial
{
    public class DataAccess
    {
        
        // =================================================================================================
        // BEGIN CUSTOMER MENU ITEMS
        // =================================================================================================
        public List<Customer> GetCustomersTable2()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Customer>("CustomerTable2").ToList();

                return output;
            }
        }

        public List<Customer> GetCustomers(string customerLastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Customer>("Customer_GetByLastName @LastName", new { LastName = customerLastName }).ToList();

                return output;
            }
        }

        public List<Customer> EnterID(string customerID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Customer>("Customer_GetByID @Customer_ID", new { Customer_ID = int.Parse(customerID) }).ToList();

                return output;
            }
        }

        public void ModifyCustomer(string customer_ID, string customerFirstName, string customerLastName,
            string customerStreetAddress, string customerCity, string customerState, string customerZipCode,
            string customerPhoneAreaCode, string customerPhoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Customer> customers = new List<Customer>();

                customers.Add(new Customer
                {
                    Customer_ID = int.Parse(customer_ID),
                    CustomerFirstName = customerFirstName,
                    CustomerLastName = customerLastName,
                    CustomerStreetAddress = customerStreetAddress,
                    CustomerCity = customerCity,
                    CustomerState = customerState,
                    CustomerZipCode = customerZipCode,
                    CustomerPhoneAreaCode = customerPhoneAreaCode,
                    CustomerPhoneNumber = customerPhoneNumber
                });

                connection.Execute("dbo.Customer_Modify_Record @Customer_ID, @CustomerFirstName, @CustomerLastName, " +
                    "@CustomerStreetAddress, @CustomerCity, @CustomerState, @CustomerZipCode, @CustomerPhoneAreaCode, " +
                    "@CustomerPhoneNumber", customers);
            }
        }

        public List<Customer> GetCustomersByCity(string customerCity)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Customer>("Customer_GetByCity @CustomerCity", new { CustomerCity = customerCity }).ToList();

                return output;
            }
        }

        public List<Customer> GetCustomersByZip(string customerZip)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Customer>("Customer_GetByZip @CustomerZipCode", new { CustomerZipCode = customerZip }).ToList();

                return output;
            }
        }

        public void InsertCustomer(string customer_ID, string customerFirstName, string customerLastName, 
            string customerStreetAddress, string customerCity, string customerState, string customerZipCode, 
            string customerPhoneAreaCode, string customerPhoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer
                {
                    Customer_ID = int.Parse(customer_ID),
                    CustomerFirstName = customerFirstName,
                    CustomerLastName = customerLastName,
                    CustomerStreetAddress = customerStreetAddress,
                    CustomerCity = customerCity,
                    CustomerState = customerState,
                    CustomerZipCode = customerZipCode,
                    CustomerPhoneAreaCode = customerPhoneAreaCode,
                    CustomerPhoneNumber = customerPhoneNumber
                });

                connection.Execute( "dbo.Customer_Insert_Record @Customer_ID, @CustomerFirstName, @CustomerLastName, " +
                    "@CustomerStreetAddress, @CustomerCity, @CustomerState, @CustomerZipCode, @CustomerPhoneAreaCode, " +
                    "@CustomerPhoneNumber", customers);
                
            }
        }

        public void DeleteCustomer(string customer_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer
                {
                    Customer_ID = int.Parse(customer_ID)
                });

                connection.Execute("dbo.Customer_Delete_Record @Customer_ID", customers);
            }
        }

        // =================================================================================================================
        // END OF CUSTOMER MENU ITEMS
        // =================================================================================================================

        // =================================================================================================================
        // BEGIN VEHICLE MENU ITEMS
        // =================================================================================================================

        public List<Vehicle> GetVehiclesTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Vehicle>("Vehicles_GetTable").ToList();

                return output;
            }
        }

        public List<Vehicle> GetVehiclesByMake(string vehicleMake)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Vehicle>("Vehicles_GetByMake @VehicleMake", new { VehicleMake = vehicleMake }).ToList();

                return output;
            }
        }


        public List<Vehicle> GetVehiclesByModel(string vehicleModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Vehicle>("Vehicles_GetByModel @VehicleModel", new { VehicleModel = vehicleModel }).ToList();

                return output;
            }
        }

        public List<Vehicle> GetVehiclesByPlate(string vehiclePlate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Vehicle>("Vehicles_GetByPlate @VehicleLicensePlate", new { VehicleLicensePlate = vehiclePlate }).ToList();

                return output;
            }
        }

        public void InsertVehicle(string vehicle_ID, string vehicleMake, string vehicleModel,
            string vehicleTrim, string vIN, string vehicleLicensePlate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                vehicles.Add(new Vehicle
                {
                    Vehicle_ID = int.Parse(vehicle_ID),
                    VehicleMake = vehicleMake,
                    VehicleModel = vehicleModel,
                    VehicleTrim = vehicleTrim,
                    VIN = vIN,
                    VehicleLicensePlate = vehicleLicensePlate
                });

                connection.Execute("dbo.Vehicle_Insert_Record @Vehicle_ID, @VehicleMake, @VehicleModel, " +
                    "@VehicleTrim, @VIN, @VehicleLicensePlate", vehicles);

            }
        }


        public List<Vehicle> EnterVehicleID(string vehicleID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Vehicle>("Vehicles_GetByID @Vehicle_ID", new { Vehicle_ID = int.Parse(vehicleID) }).ToList();

                return output;
            }
        }


        public void ModifyVehicle(string vehicle_ID, string vehicleMake, string vehicleModel,
            string vehicleTrim, string vIN, string vehicleLicensePlate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Vehicle> vehicles = new List<Vehicle>();

                vehicles.Add(new Vehicle
                {
                    Vehicle_ID = int.Parse(vehicle_ID),
                    VehicleMake = vehicleMake,
                    VehicleModel = vehicleModel,
                    VehicleTrim = vehicleTrim,
                    VIN = vIN,
                    VehicleLicensePlate = vehicleLicensePlate
                });

                connection.Execute("dbo.Vehicle_Modify_Record @Vehicle_ID, @VehicleMake, @VehicleModel, " +
                    "@VehicleTrim, @VIN, @VehicleLicensePlate", vehicles);

            }
        }

        public void DeleteVehicle(string vehicle_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                vehicles.Add(new Vehicle
                {
                    Vehicle_ID = int.Parse(vehicle_ID)
                });

                connection.Execute("dbo.Vehicle_Delete_Record @Vehicle_ID", vehicles);
            }
        }

        // =================================================================================================================
        // END VEHICLE MENU ITEMS
        // =================================================================================================================

        // =================================================================================================================
        // BEGIN EMPLOYEE MENU ITEMS
        // =================================================================================================================

        public List<Employee> GetEmployeesTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Employee>("Employee_GetTable").ToList();

                return output;
            }
        }

        public List<Employee> GetEmployeesByFirstName(string empFirstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Employee>("Employee_GetByFirstName @EmployeeFirstName", new { EmployeeFirstName = empFirstName }).ToList();

                return output;
            }
        }


        public List<Employee> GetEmployeesByJobTitle(string jobTitle)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Employee>("Employee_GetByJobTitle @JobTitle", new { JobTitle = jobTitle }).ToList();

                return output;
            }
        }


        // =================================================================================================================
        // END EMPLOYEE MENU ITEMS
        // =================================================================================================================

        // =================================================================================================================
        // BEGIN ESTIMATES MENU ITEMS
        // =================================================================================================================

        public List<Estimates> GetEstimateTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Estimates>("Estimate_GetTable").ToList();

                return output;
            }
        }

        public List<Estimates> GetEstimateByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Estimates>("Estimate_GetByID @Estimate_ID", new { Estimate_ID = estimate_ID }).ToList();

                return output;
            }
        }

        // ===============================================================================
        // ESTIMATE FORM CALLS TRIGGERED BY ESTIMATE SEARCH BUTTON
        // ===============================================================================
        public float GetEstimateZipByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerZipCode FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                float answer2 = float.Parse(answer);

                return answer2;
            }
        }

        public string GetEstimateStateByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerState FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateCityByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerCity FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateStreetByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerStreetAddress FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimatefNameByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerFirstName FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimatelNameByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerLastName FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateDateByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Date FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateAreaCodeByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerPhoneAreaCode FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimatePhoneNumberByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Customers.CustomerPhoneNumber FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateServiceByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Work_Order.OrderDescription FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateMakeByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Vehicles.VehicleMake FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateModelByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Vehicles.VehicleModel FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimateTrimByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Vehicles.VehicleTrim FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;
            }
        }

        public string GetEstimatePlateByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Vehicles.VehicleLicensePlate FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;

            }
        }

        public string GetEstimateVINByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Vehicles.VIN FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;

            }
        }


        public string GetEstimatePartsByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Estimate.PartsCost FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;

            }
        }

        public string GetEstimateLaborByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Estimate.LaborCost FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;

            }
        }

        public string GetEstimateTotalByID(string estimate_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "SELECT Estimate.PriceEstimate FROM Estimate JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                "WHERE Estimate.Estimate_ID = " + estimate_ID;

                var answer = connection.QueryFirst<string>(sql);

                return answer;

            }
        }


        // =================================================================================================================
        // END OF ESTIMATE MENU ITEMS
        // =================================================================================================================

        // =================================================================================================================
        // BEGIN INVOICE MENU ITEMS
        // =================================================================================================================


        public List<Invoices> GetInvoiceTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {
                var output = connection.Query<Invoices>("Invoice_GetTable").ToList();

                return output;
            }
        }

        public string GetInvoiceZipByID(string invoice_ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var guts = "JOIN PartsOrdered ON Invoice.Part_ID = PartsOrdered.Part_ID " +
                    "JOIN Estimate ON PartsOrdered.Estimate_ID = Estimate.Estimate_ID" +
                    "JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                    "JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID " +
                    "JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID WHERE Invoice.Invoice_ID = ";


                // var sql = "SELECT Customers.CustomerZipCode FROM Invoice " + guts + invoice_ID;

                var sql = "SELECT Customers.CustomerZipCode FROM Invoice JOIN PartsOrdered ON Invoice.Part_ID = PartsOrdered.Part_ID " +
                    "JOIN Estimate ON PartsOrdered.Estimate_ID = Estimate.Estimate_ID JOIN Work_Order ON Estimate.Order_ID = Work_Order.Order_ID " +
                    "JOIN Customers ON Estimate.Customer_ID = Customers.Customer_ID JOIN Vehicles ON Estimate.Vehicle_ID = Vehicles.Vehicle_ID " +
                    "WHERE Invoice.Invoice_ID = " + invoice_ID;


                Console.WriteLine(sql);

                var answer = connection.QueryFirst<string>(sql);

                // var answer = "booger";

                return answer;
            }
        }










        /*public  GetHourlyWage(string number)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Marys_Auto_Shop_DB")))
            {

                var sql = "select HourlyWage from Employee where Employee_ID = " + number;

                var answer = connection.QueryFirst<string>(sql);
                Console.WriteLine(answer);
                Console.ReadLine();

                float answer2 = float.Parse(answer);

                return answer2;

            }

        }
        */


    }

}


