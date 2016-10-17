using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Cat : Mammal
    {

        public Cat(double inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, false)
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Meow");
        }

        public override void Move(int inputXPos, int inputYPos)
        {
            Console.WriteLine("The cat looks where it is suppsed to go. It decides to not give a shit and lie down in the sun");
        }
    }
}