using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_2
{
    class Program
    {
        public static int HOW_MANY_RANDOMS = 3;

        static void Main(string[] args)
        {
            //Den dagen jag gör sju listor för typ samma sak. Skjut mig. Jag gör en lista.
            List<Animal> animalList = new List<Animal>();

            for (int i = 0; i < HOW_MANY_RANDOMS; i++)
            {
                animalList.Add(new Kolibri(
            }
           
            Console.ReadKey();
        }
    }
}
