using Dealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
    public class VehicleLogic
    {
        public static PercentageIncrease MilleagePercentageIncrease { get; set; }
        public static PercentageIncrease YearPercentageIncrease { get; set; }

        public VehicleLogic()
        {
            //MilleagePercentageIncrease = new PercentageIncrease(100000,150000,0.15);
        }

        public VehicleLogic(Vehicle vehicle)
        {
            
        }
    }

}
