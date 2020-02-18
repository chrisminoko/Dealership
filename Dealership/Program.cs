using Dealership.Logic;
using Dealership.Model;
using System;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new ModelLogic();
            m.DisplaySelections();
            Console.ReadKey();

            //var vehicle = new VehicleLogic();
            //vehicle.BuyVehicle();
            //Console.ReadKey();
        }
    }
}
