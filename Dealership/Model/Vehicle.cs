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
    
    
    }
    public class Vehicle
    {
        public double Millege { get; set; }
        public List<string> Specs { get; set; }
        public List<string> ServiceHistory { get; set; }
        public double BookValue { get; set; }
        public int Year { get; set; }
        public List<string> Color { get; set; }

  
        public Vehicle(double millege,List<string>spec, List<string> servicehistory, double bookvalue,int year,List<string> color)
        {
            Millege = millege;
            Specs = spec;
            ServiceHistory = servicehistory;
            BookValue = bookvalue;
            Year = year;
            Color = color;
        }
    }
}
