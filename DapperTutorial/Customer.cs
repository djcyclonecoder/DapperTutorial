using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial
{
    public class Customer
    {
        public int Customer_ID { get; set; }    
        public string CustomerFirstName { get; set;}
        public string CustomerLastName { get; set;} 
        public string CustomerStreetAddress { get; set;}
        public string CustomerCity { get; set;}
        public string CustomerState { get; set;}
        public string CustomerZipCode { get; set;}
        public string CustomerPhoneAreaCode { get; set;}    
        public string CustomerPhoneNumber { get; set;}

        public string FullInfo
        {
            get
            {
                return $"{ Customer_ID + "   "} { CustomerFirstName } { CustomerLastName + "   "} { CustomerStreetAddress + "   " } " +
                    $"{ CustomerCity + "   "} { CustomerState + "   "} { CustomerZipCode + "   "}" +
                    $"{ "(" + CustomerPhoneAreaCode + ")"} { CustomerPhoneNumber }";
            }
        }


    }
}
