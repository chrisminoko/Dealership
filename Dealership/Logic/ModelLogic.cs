using Dealership.Model;
using Dealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Dealership.Logic
{
   public class ModelLogic
    {
     public List<VehicleModel> VehicleModels { get; set; }
     public List<VehicleModel> distinct { get; set; }
        int i = 0;
        public ModelLogic()
        {
            VehicleModels = new List<VehicleModel>()
            {
                new VehicleModel(1,"BMW",Model.VehicleType.Car,1,"M4"),
                new VehicleModel(1,"BMW",Model.VehicleType.Car,1,"M6"),
                new VehicleModel(1,"BMW",Model.VehicleType.Car,1,"M8"),
                new VehicleModel(2,"Merceedes",Model.VehicleType.Car,2,"C63"),
                new VehicleModel(3,"Toyata",Model.VehicleType.Truck,3,"RoadRave3"),
                new VehicleModel(4,"VW",Model.VehicleType.Car,1,"Pollo6")
            };

           distinct= VehicleModels.Distinct().ToList();

        }
        public void DisplaySelections()
        {
            Console.WriteLine("***Welcome to We buy Cars *** \n\n");
            Console.WriteLine("Types of Vehicles Availabe\n");

            foreach (var vehicleType in Enum.GetNames(typeof(VehicleType)))
            {
                i++;
                Console.WriteLine(vehicleType + " "+i);
              
            }
            Console.WriteLine("Please select what would you want to see\n");
            int VehicleTypePosition = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            
            foreach (var vehicleType in distinct) 
            {
                if (VehicleTypePosition == vehicleType.VehicleType_postion)
                {
                    vehicleType.Name();
                }
               
            }
            Console.WriteLine("Please select the one you want ");

            string name = Console.ReadLine();
            foreach (var vehicleType in VehicleModels) 
            {

                if (name == vehicleType.VehicleName)
                {
                    vehicleType.Display();

                }

            }

        }
    }
}
