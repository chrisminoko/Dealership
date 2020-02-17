using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public class PercentageIncrease
    {
        public int Upper { get; set; }
        public int Lower { get; set; }
        public decimal PercentageCharged { get; set; }

        public PercentageIncrease() { }

        public PercentageIncrease(int upper, int lower,decimal percentagecharge,)
        {
            Upper = upper;
            Lower = lower;
            PercentageCharged = percentagecharge;
        }
    }
}
