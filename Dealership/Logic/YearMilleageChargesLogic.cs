using Dealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
   public class YearMilleageChargesLogic
    {
        public  List<YearMilleageCharges> MilleagePriceIncrease;
        public  List<YearMilleageCharges> YearPercentageIncrease;
        public YearMilleageChargesLogic()
        {
            MilleagePriceIncrease = new List<YearMilleageCharges>()
            {
                new YearMilleageCharges{Lower=0,Upper=100000,Charges=30000,ExtraPecentages=0.4F},
                new YearMilleageCharges{Lower=100000,Upper=150000,Charges=15000,ExtraPecentages=0.3F},
                new YearMilleageCharges{Lower=150000,Upper=int.MaxValue,Charges=5000 ,ExtraPecentages=0.1F}
            };

            YearPercentageIncrease = new List<YearMilleageCharges>()
            {
              new YearMilleageCharges{Lower=0,Upper=2011,Charges=0.15F,ExtraPecentages=0.15F},
              new YearMilleageCharges { Lower=2011,Upper=2018,Charges=0.1F,ExtraPecentages=0.10F},
              new YearMilleageCharges { Lower=201,Upper=2018,Charges=0.1F,ExtraPecentages=0.05F},

            };
        }
        public decimal MilleagePrice(Vehicle _vehicle)
        {
            decimal BasicPrice = 0;
            foreach (var MilleageInBracket in MilleagePriceIncrease)
            {
                if (_vehicle.Millege > MilleageInBracket.Lower && _vehicle.Millege <= MilleageInBracket.Upper && _vehicle.VehicleType == VehicleType.Bus || _vehicle.VehicleType==VehicleType.Truck)
                {
                    BasicPrice = _vehicle.BookValue + Convert.ToDecimal(MilleageInBracket.Charges);
                    return (BasicPrice * Convert.ToDecimal(MilleageInBracket.Charges)) + BasicPrice;
                }
                else
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
                if (_vehicle.Millege > MilleageInBracket.Lower && _vehicle.Millege <= MilleageInBracket.Upper && _vehicle.VehicleType == VehicleType.Bus || _vehicle.VehicleType == VehicleType.Truck)
                {
                    return _vehicle.BookValue * Convert.ToDecimal(MilleageInBracket.Charges + MilleageInBracket.ExtraPecentages);
                }
                else 
                {
                    return _vehicle.BookValue * Convert.ToDecimal(MilleageInBracket.Charges);
                }
            }
            return 0;
        }
    }
}
