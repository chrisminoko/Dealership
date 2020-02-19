using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
   public class start
    {
        public void Run() 
        {
            try
            {
                
                Console.WriteLine("**Would You want to browse through the List of vehicles we have or you want to sell to us a vehicle**\n");
                Console.WriteLine("To browese Press 1 And to Sell Press 2 \n\n");
                var choice = int.Parse(Console.ReadLine());
                if (choice == 2)
                {
                    var vehicle = new VehicleLogic();
                    vehicle.BuyVehicle();
                    Console.ReadKey();
                }
                else if (choice == 1)
                {
                    var m = new ModelLogic();
                    m.DisplaySelections();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Option Made");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("There was an error "+e.Message);
            }
               
        }
    }
}
