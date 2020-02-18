using Dealership.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Logic
{
    public class MakeLogic
    {
        public List<Make> Makes { get; set; }
        public MakeLogic()
        {
            Makes = new List<Make>()
            {
            new Make(1,"BMW"),
            new Make(2,"Merceedes"),
            new Make(3,"Toyata"), 
            new Make(4,"VW"),

            };
        }
    }
}
