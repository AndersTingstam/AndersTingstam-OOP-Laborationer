﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_3
{
    public class Concert : Event
    {
        public Concert() : base()
        {
            Type = "Concert";
            Name = RandomiseName();
        }

    }
}