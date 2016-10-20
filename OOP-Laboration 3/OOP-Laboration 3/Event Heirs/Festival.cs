using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_3
{
    public class Festival : Event
    {
        public Festival() : base()
        {
            Type = "Festival";
            Name = RandomiseName();
        }
    }
}