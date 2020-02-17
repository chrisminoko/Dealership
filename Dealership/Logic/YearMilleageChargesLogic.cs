using Dealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
   public class YearMilleageChargesLogic
    {
        private static List<YearMilleageCharges> MilleagePriceIncrease;
        private static List<YearMilleageCharges> YearPercentageIncrease;

        public YearMilleageChargesLogic()
        {
            MilleagePriceIncrease = new List<YearMilleageCharges>()
            {
                new YearMilleageCharges{Lower=0,Upper=100000,Charges=30000},
                new YearMilleageCharges{Lower=100000,Upper=150000,Charges=15000},
                new YearMilleageCharges{Lower=150000,Upper=int.MaxValue,Charges=5000 }
            };

            YearPercentageIncrease = new List<YearMilleageCharges>()
            {
              new YearMilleageCharges{Lower=0,Upper=2011,Charges=0.15F },
              new YearMilleageCharges { Lower=2011,Upper=2018,Charges=0.1F},
              new YearMilleageCharges { Lower=201,Upper=2018,Charges=0.1F},

            };
        }

        public decimal MilleagePrice(Vehicle _vehicle)
        {

            foreach (var MilleageInBracket in MilleagePriceIncrease)
            {
                if (_vehicle.Millege > MilleageInBracket.Lower && _vehicle.Millege <= MilleageInBracket.Upper && _vehicle.VehicleType == VehicleType.Bus)
                {

                    return _vehicle.BookValue + Convert.ToDecimal(MilleageInBracket.Charges);
                }

            }
            return 0;
        }
      

        public decimal YearPrice(Vehicle _vehicle)
        {

            foreach (var MilleageInBracket in YearPercentageIncrease)
            {
                if (_vehicle.Millege > MilleageInBracket.Lower && _vehicle.Millege <= MilleageInBracket.Upper)
                {

                    return _vehicle.BookValue * Convert.ToDecimal(MilleageInBracket.Charges);
                }

            }
            return 0;
        }
    }
}
