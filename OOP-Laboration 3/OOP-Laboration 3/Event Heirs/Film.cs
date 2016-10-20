using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_3
{
    public class Film : Event
    {
        public Film() : base()
        {
            Type = "Film";
            Name = RandomiseName();
        }
    }
}