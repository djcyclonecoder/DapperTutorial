using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string JobTitle { get; set; }
        public string HourlyWage { get; set; }
        public string Experience { get; set; }

        public string FullInfo
        {
            get
            {
                float boogery = float.Parse(HourlyWage);
                string bogey = boogery.ToString("c2");

                return $"{ Employee_ID + "   "} { EmployeeFirstName + "  " } { EmployeeLastName + "   "} { JobTitle + "   " } " +
                    $"{ bogey + "   "} { Experience }";
            }
        }


    }
}



