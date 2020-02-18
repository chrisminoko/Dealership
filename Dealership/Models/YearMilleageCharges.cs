using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public class YearMilleageCharges
    {
        public int Upper { get; set; }
        public int Lower { get; set; }
        public float Charges { get; set; }
        public float? ExtraPecentages { get; set; }

        public YearMilleageCharges() { }

        public YearMilleageCharges(int upper, int lower, float charge,float extrapercentage)
        {
            Upper = upper;
            Lower = lower;
            Charges = charge;
            ExtraPecentages = extrapercentage;
        }


    }
}
