using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public abstract class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool HasWings { get; set; }

        public int NumberOfLegs
        {
            get
            {
                if (HasWings)
                    return this.NumberOfLimbs - 2;
                else
                    return this.NumberOfLimbs;
            }
        }

        public Bird(decimal inputWeight, int inputAge, int inputNumberOfLimbs, bool inputCanFly) 
            : base(inputWeight, inputAge, inputNumberOfLimbs)
        {
            HasWings = true; //I'm lazy now.
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