using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public abstract class Bird : Animal
    {
        public static int w
        public bool CanFly { get; set; }

        public Bird(double inputWeight, int inputAge, int inputNumberOfLimbs, bool inputCanFly) 
            : base(inputWeight, inputAge, inputNumberOfLimbs)
        {
            CanFly = inputCanFly;
        }

        public void Sing()
        {
            Console.WriteLine("This little birdy sings a beautiful song");
        }

        public override void Move(int inputXPos, int inputYPos)
        {
            if (CanFly)
                Console.WriteLine("This little birdy takes off far into the sky! It flies to X: " + inputXPos + " Y: " + inputYPos);
            else
                Console.WriteLine("This little birdy wobbles and slowly walks to X: " + inputXPos + " Y: " + inputYPos);
        }

        public override List<string> ThingsToDo()
        {
            List<string> outputstring = base.ThingsToDo();

            outputstring.Add("Sing");

            return outputstring;
        }

    }
}