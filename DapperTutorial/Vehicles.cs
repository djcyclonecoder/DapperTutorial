using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial
{
        public class Vehicle
        {
            public int Vehicle_ID { get; set; }
            public string VehicleMake { get; set; }
            public string VehicleModel { get; set; }
            public string VehicleTrim { get; set; }
            public string VIN { get; set; }
            public string VehicleLicensePlate { get; set; }

            public string FullInfo
            {
                get
                {
                    return $"{ Vehicle_ID + "   "} { VehicleMake + "  " } { VehicleModel + "   "} { VehicleTrim + "   " } " +
                        $"{ VIN + "   "} { VehicleLicensePlate }";
                }
            }


        }
    
}
