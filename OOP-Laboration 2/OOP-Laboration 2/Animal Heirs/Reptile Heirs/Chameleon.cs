using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_2
{
    public class Chameleon : Reptile
    {

        public Chameleon(decimal inputWeight, int inputAge, int inputNumberOfLimbs)
            : base(inputWeight, inputAge, inputNumberOfLimbs, true)
        {

        }

        public void Camouflage()
        {
            Console.WriteLine("The chameleon adapts it's colors to the enviroment. It gains +10 on stealth checks for 5 turns.");
        }

        public override List<string> ThingsToDo()
        {
            List<string> outputstring = base.ThingsToDo();

            outputstring.Add("Camouflage");

            return outputstring;
        }

        public override string ToString()
        {
            return "Chameleon | " + base.ToString();
        }
    }
}