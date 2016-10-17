using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Gecko : Reptile
    {
        public Gecko(decimal inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, false)
        {

        }

        public override string ToString()
        {
            return "Gecko | " + base.ToString();
        }
    }
}