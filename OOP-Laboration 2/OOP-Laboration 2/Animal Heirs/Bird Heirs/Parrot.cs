using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Parrot : Bird
    {

        public Parrot(double inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, true)
        {

        }

        public override void Talk()
        {
            Console.WriteLine("The parrot says: 'For the Emperor! Caaaw. Burn the heretics, purge caaaaw the unclean.'");
        }

    }
}