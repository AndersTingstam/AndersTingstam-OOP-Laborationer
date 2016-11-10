using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_4
{
    public abstract class Vehicle
    {
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsUsed { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,20} {3,20}", Brand, Model, IsUsed == true ? "Used Vehicle" : "Brand new", Price );
        }
    }
}