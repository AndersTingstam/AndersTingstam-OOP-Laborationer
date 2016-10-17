using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Human : Mammal
    {
        public Dog DomesticatedDog { get; set; }

        public Human(double inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, true)
        {

        }

        public void PetDog()
        {
            if (DomesticatedDog != null)
                Console.WriteLine("The human pets the dog that it own. There there, who's a good boy/girl/apachedog?");
            else
                Console.WriteLine("The human is sad since it has no dog. And therefore can't pet any.");
        }

        public override void Talk()
        {
            Console.WriteLine("I have a boyfriend.");
        }

        public override void Move(int inputXPos, int inputYPos)
        {
            Console.WriteLine("The human ignores your input on where it should go. It instead goes to the fridge, gets a huge coke and then returns to the computer.");
        }

        public override List<string> ThingsToDo()
        {
            List<string> outputstring = base.ThingsToDo();

            outputstring.Add("Pet Dog");

            return outputstring;
        }
    }
}