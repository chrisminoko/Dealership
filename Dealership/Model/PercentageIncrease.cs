using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public class PercentageIncrease
    {
        public int Upper { get; set; }
        public int Lower { get; set; }
        public double PercentageCharged { get; set; }

        public PercentageIncrease() { }

        public PercentageIncrease(int upper, int lower,double percentagecharge)
        {
            Upper = upper;
            Lower = lower;
            PercentageCharged = percentagecharge;
        }
    }
}
