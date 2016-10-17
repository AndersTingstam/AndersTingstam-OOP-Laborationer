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
        public static int EVERYONE_HAS_FOUR_LIMBS = 4;
        public static Random rng = new Random();


        static void Main(string[] args)
        {
            //Den dagen jag gör sju listor för typ samma sak. Skjut mig. Jag gör en lista.
            List<Animal> animalList = new List<Animal>();

            for (int i = 0; i < HOW_MANY_RANDOMS; i++)
            {
                animalList.Add(new Kolibri(rng.NextDouble() * (double)AnimalStats.birdWeightMax + (double)AnimalStats.birdWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.birdAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Parrot(rng.NextDouble() * (double)AnimalStats.birdWeightMax + (double)AnimalStats.birdWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.birdAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Dog(rng.NextDouble() * (double)AnimalStats.dogWeightMax + (double)AnimalStats.dogWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.dogAgeMax), EVERYONE_HAS_FOUR_LIMBS));
            }
           
            Console.ReadKey();
        }
    }
}
