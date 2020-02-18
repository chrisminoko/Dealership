using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Models
{
   public class Make
    {
        public int ID { get; set; }
        public string VehicleName { get; set; }
        public Make()
        {
        }
        public Make(int id, string vehiclename)
        {
            ID = id;
            VehicleName = vehiclename;
        }
    }
}
