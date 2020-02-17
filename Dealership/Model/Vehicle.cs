using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public enum ServiceHistory
    {
        Full=40,
        Medium=30,
        None
    }

    public enum Spec
    {
        High,
        Low,
        Medium,

    }
    public enum Color
    {
        Flat,
        Metalic
    }
    public enum VehicleType
    {
        Car,
        Truck,
        Bus
    }
    public class Vehicle
    {
        public int Millege { get; set; }
        public decimal BookValue { get; set; }
        public ServiceHistory ServiceHistory { get; set; }
        public VehicleType VehicleType { get; set; }
        public Spec Spec { get; set; }
        public Color Color { get; set; }
        public int Year { get; set; }


        public Vehicle(int millege, decimal bookvalue, ServiceHistory servicehistory, Spec spec, Color color, int years, VehicleType vehicleType)
        {
            Millege = millege;
            BookValue = bookvalue;
            ServiceHistory = servicehistory;
            Spec = spec;
            Color = color;
            Year = years;
            VehicleType = vehicleType;
        }
    }

}
