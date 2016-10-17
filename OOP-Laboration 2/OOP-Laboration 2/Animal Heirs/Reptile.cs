using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public abstract class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public int NumberOfLegs
        {
            get { return NumberOfLimbs; }
        }

        public Reptile(double inputWeight, int inputAge, int inputNumberOfLimbs, bool inputIsColdBlooded)
            : base(inputWeight, inputAge, inputNumberOfLimbs)
        {
            IsColdBlooded = inputIsColdBlooded;
        }

        public override void Move(int inputXPos, int inputYPos)
        {
            Console.WriteLine("The reptile skitters quickly over the surface to X: " + inputXPos + " Y: " + inputYPos);
        }

        public override void Talk()
        {
            Console.WriteLine("No matter how much you try to it to make a noise. The lizard just silently stares at you");
        }

    }
}