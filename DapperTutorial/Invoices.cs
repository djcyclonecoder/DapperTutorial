using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial
{
    public class Invoices
    {
        public int Invoice_ID { get; set; }
        public string Part_ID { get; set; }
        public string Date { get; set; }
        public string FinalPrice { get; set; }
        public string WorkDoneDescription { get; set; }


        public string FullInfo
        {
            get
            {
                float boogery = float.Parse(FinalPrice);
                string bogey = boogery.ToString("c2");
                

                DateTime dateAndTime = DateTime.Parse(Date);
                String date = dateAndTime.ToString("MM/dd/yyyy");
                

                return $"{ Invoice_ID + "   "} { Part_ID + "  " } { WorkDoneDescription + "   "}  " +
                    $"{ bogey + "   "} { date }";
            }
        }


    }
}
