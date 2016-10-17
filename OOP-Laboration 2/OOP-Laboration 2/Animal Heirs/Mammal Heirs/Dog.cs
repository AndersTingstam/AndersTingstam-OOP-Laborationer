using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Dog : Mammal
    {
        public Dog(decimal inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, false)
        {
            
        }

        public void PuppyEyes(Human inputHuman)
        {
            Console.WriteLine("The dog uses Puppyeyes on the target Human.\n It's Super Effective!");
        }

        public override void Talk()
        {
            Console.WriteLine("Wooof");
        }

        public override void Move(int inputXPos, int inputYPos)
        {
            Console.WriteLine("The dog runs fast as a motherhumper to X: " + inputXPos + " Y: " + inputYPos + ". VROOOOOOM");
        }

        public override List<string> ThingsToDo()
        {
            List<string> outputstring = base.ThingsToDo();

            outputstring.Add("Puppy Eyes");

            return outputstring;
        }

        public override string ToString()
        {
            return "Dog | " + base.ToString();
        }
    }
}