﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Kolibri : Bird
    {
        public Kolibri(decimal inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, true)
        {

        }

        public override void Talk()
        {
            base.Sing(); //Yes, this is very lazy.
        }

        public override string ToString()
        {
            return "Kolibri | " + base.ToString();
        }
    }
}