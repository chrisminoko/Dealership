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
            var ExtraCharges = new YearMilleageChargesLogic();
            Console.WriteLine("******** Welcome to We buy Cars **********\n\n");
            Console.WriteLine("******** General Car Information **********\n\n");
            var _vehicle= new Vehicle();
            Console.WriteLine("Please Enter your Base price of the vehicle\n");
            _vehicle.BookValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your mileage\n");
            _vehicle.Millege = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("\n");
           
            while (_vehicle.Millege <0 ) 
            {
                Console.WriteLine("Please Enter your a correct value, Negative are not allowed and letters allowed");
                _vehicle.Millege = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("Please select the type of Vehicle you want \n");
                foreach (var type in Enum.GetNames(typeof(VehicleType)))
                {
                    Console.WriteLine(type);
                }
              
                var SelectedVehicleType = Console.ReadLine();
                if (Enum.IsDefined(typeof(VehicleType), SelectedVehicleType))
                {
                    _vehicle.VehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), SelectedVehicleType);
                    break;
                }
                else 
                {
                    Console.WriteLine("\n\n Invalid Vehicle Type Selected, Please try again");
                }
            } 
            while (true);
            do
            {
                Console.WriteLine("Please select the spec type of your vehicle \n");
                foreach (var type in Enum.GetNames(typeof(Spec)))
                {
                    Console.WriteLine(type);
                }
               
                var SelectedVehicleSpec = Console.ReadLine();
                if (Enum.IsDefined(typeof(Spec), SelectedVehicleSpec))
                {
                    _vehicle.Spec = (Spec)Enum.Parse(typeof(Spec), SelectedVehicleSpec);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n Invalid Vehicle Spec Selected, Please try again");
                }
            }
            while (true);
            do
            {
                Console.WriteLine("Please select the color type of your vehicle \n");
                foreach (var color in Enum.GetNames(typeof(Color)))
                {
                    Console.WriteLine(color);
                }

                var SelectedVehicleSpec = Console.ReadLine();
                if (Enum.IsDefined(typeof(Color), SelectedVehicleSpec))
                {
                    _vehicle.Color = (Color)Enum.Parse(typeof(Color), SelectedVehicleSpec);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n Invalid Vehicle Color Selected, Please try again");
                }
            }
            while (true);
            do
            {
                Console.WriteLine("Please select the service history of your vehicle \n");
                foreach (var servicehistory in Enum.GetNames(typeof(ServiceHistory)))
                {
                    Console.WriteLine(servicehistory);
                }

                var selectedServiceHistory = Console.ReadLine();
                if (Enum.IsDefined(typeof(ServiceHistory), selectedServiceHistory))
                {
                    _vehicle.ServiceHistory = (ServiceHistory)Enum.Parse(typeof(ServiceHistory), selectedServiceHistory);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n Invalid Vehicle service history Selected, Please try again");
                }
            }
            while (true);

            Console.WriteLine("The selling price is R"+ SellingPrice(ExtraCharges, _vehicle));
       
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
