using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Model
{
    public enum ServiceHistory 
    {
    Full,
    Medium,
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
    public class Vehicle
    {
        public int Millege { get; set; }
        public decimal BookValue { get; set; }
        public ServiceHistory ServiceHistory { get; set; }
        public Spec Spec { get; set; }
        public Color Color{ get; set; }
        public int Year { get; set; }

  
        public Vehicle(int millege,decimal bookvalue,ServiceHistory servicehistory,Spec spec, Color color, int years)
        {
            Millege = millege;
            BookValue = bookvalue;
            ServiceHistory = servicehistory;
            Spec = spec;
            Color = color;
            Year = years;
        }
    }
}
