using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial
{
    public class Estimates
    {
        public int Estimate_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Vehicle_ID { get; set; }
        public string Order_ID { get; set; }
        public string PriceEstimate { get; set; }
        public string Date { get; set; }


        public string FullInfo
        {
            get
            {
                float boogery = float.Parse(PriceEstimate);
                string bogey = boogery.ToString("c2");

                DateTime dateAndTime = DateTime.Parse(Date);
                String date = dateAndTime.ToString("MM/dd/yyyy");

                return $"{ Estimate_ID + "   "} { Customer_ID + "  " } { Vehicle_ID + "   "} { Order_ID + "   " } " +
                    $"{ bogey + "   "} { date }";
            }
        }


    }
}
