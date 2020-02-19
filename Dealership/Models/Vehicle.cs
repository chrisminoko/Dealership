using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public enum ServiceHistory
    {
        Full=40,
        Medium=30,
        None=0
    }
    public enum ExtraServicHistoryCharges 
    {
        Full = 15,
        Medium = 10,
        None = 5

    }
    public enum Spec
    {
        High=1,
        Low=2,
        Medium=3,

    }
    public enum Color
    {
        Flat=0,
        Metalic= 5000
    }
    public enum VehicleType
    {
        Car=1,
        Truck=2,
        Bus=3
    }
    public class Vehicle
    {
        public int  Millege { get; set; }
        public decimal BookValue { get; set; }
        public ServiceHistory ServiceHistory { get; set; }
        public VehicleType VehicleType { get; set; }
        public ExtraServicHistoryCharges ExtraServicHistoryCharges { get; set; }
        public Spec Spec { get; set; }
        public Color Color { get; set; }
        public int Year { get; set; }
        public Vehicle()
        {

        }
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
