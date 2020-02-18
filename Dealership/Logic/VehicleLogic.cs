using Dealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
    public class VehicleLogic
    {
        public void BuyVehicle() 
        {

            Console.WriteLine("******** Welcome to We buy Cars **********\n\n");
            Vehicle vehiclel= new Vehicle();

            Console.WriteLine("Please Enter your mileage");
            vehiclel.Millege = int.Parse(Console.ReadLine()) ;
            

            while (vehiclel.Millege <0 ) 
            {
                Console.WriteLine("Please Enter your a correct value, Negative are not allowed and letters allowed");
                vehiclel.Millege = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please Select the type of Specs of the car\n");
            int i = 0;
            foreach (var spec in  Enum.GetNames(typeof(Spec))) 
            {
                //Console.WriteLine(spec+" "+i);
                //if (Enum.GetValues(typeof(Spec))) 
                //{
                
                //}
                //i++;
            }
            //Console.WriteLine(Spec+i);
           
        }

        public decimal ColorPrice(Vehicle _vehicle)
        {
            return (decimal)_vehicle.Color;
        }

        public decimal ServiceHistoryCharges(Vehicle  _vehicle) 
        {
            if (_vehicle.VehicleType.Equals(VehicleType.Bus)|| _vehicle.VehicleType.Equals(VehicleType.Truck)) 
            {
                return _vehicle.BookValue* ((decimal)_vehicle.ServiceHistory+ (decimal)_vehicle.ExtraServicHistoryCharges)/100;
          
            }
            return _vehicle.BookValue * ((decimal)_vehicle.ServiceHistory);
        }
        public decimal SellingPrice(YearMilleageChargesLogic ExtraCharges, Vehicle _vehicle) 
        {
           return ExtraCharges.MilleagePrice(_vehicle) + ExtraCharges.YearPrice(_vehicle) + ColorPrice(_vehicle) + ServiceHistoryCharges(_vehicle);
          
        }


    }

}
