using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public abstract class Animal
    {
        public bool IsAlive { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public int NumberOfLimbs { get; set; }
        public List<string> Activities { get; set; }

        public Animal(double inputWeight, int inputAge, int inputNumberOfLimbs)
        {
            this.IsAlive = true;
            Weight = inputWeight;
            Age = inputAge;
            NumberOfLimbs = inputNumberOfLimbs;
            Activities = ThingsToDo();
        }

        public virtual void Talk()
        {
            //Empty, like my fridge.
        }

        public virtual void Move(int inputXPos, int inputYPos)
        {
            //Void. Like my heart. *insert edgy emokid here*
        }

        public virtual void Breed(Animal inputBreedingPartner)
        {
            if (this.GetType() != inputBreedingPartner.GetType())
                Console.WriteLine("Heresy! This union is foul and the Emperor will not approve of it!");
            else
                Console.WriteLine(this.GetType() + " successfully mated with another " + inputBreedingPartner.GetType() + ". ´\nImagine sexy time here");
        }

        public virtual List<string> ThingsToDo()
        {
            List<string> outputString = new List<string>();

            outputString.Add("Talk");
            outputString.Add("Move");
            outputString.Add("Breed");

            return outputString;
        }
    }
}