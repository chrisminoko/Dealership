using Dealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Models
{
    public class VehicleModel : Make
    {
        public int ModelID { get; set; }
        public string Model { get; set; }
        public VehicleType VehicleType { get; set; }
        public int VehicleType_postion { get; set; }
        public VehicleModel(int vehicleid, string vehiclename, VehicleType vehicleType, int modelid, string model) : base(vehicleid, vehiclename)
        {
            ModelID = modelid;
            Model = model;
            VehicleType = vehicleType;
            VehicleType_postion = (int)vehicleType;
        }
        public void Display()
        {
            Console.Write(VehicleName + " " + VehicleType + " " + " " + Model + "\n\n");
        }
        public void Name ()
        {
            Console.Write(VehicleName + " " + "\n");
        }
    }
}
