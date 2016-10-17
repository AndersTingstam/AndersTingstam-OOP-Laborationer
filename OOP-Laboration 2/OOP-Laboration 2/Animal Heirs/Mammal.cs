using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public abstract class Mammal : Animal
    {
        public bool HasHands { get; set; }

        public int NumberOfLegs
        {
            get
            {
                if (HasHands)
                    return this.NumberOfLimbs - 2;
                else
                    return this.NumberOfLimbs;
            }
        }

        public Mammal(double inputWeight, int inputAge, int inputNumberOfLimbs, bool inputHasHands)
            : base(inputWeight, inputAge, inputNumberOfLimbs)
        {
            HasHands = inputHasHands;
        }

    }
}