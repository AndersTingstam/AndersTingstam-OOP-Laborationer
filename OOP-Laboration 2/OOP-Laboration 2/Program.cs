using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_2
{
    class Program
    {
        public static int HOW_MANY_RANDOMS = 8;
        public static int EVERYONE_HAS_FOUR_LIMBS = 4;
        public static Random rng = new Random();

        //Den dagen jag gör sju listor för typ samma sak. Skjut mig. Jag gör bara en lista.
        public static List<Animal> animalList = new List<Animal>();

        static void Main(string[] args)
        {
            //Adding some randomly generated animals of all types.
            for (int i = 0; i < HOW_MANY_RANDOMS; i++)
            {
                animalList.Add(new Kolibri((decimal)rng.NextDouble() * (decimal)AnimalStats.birdWeightMax + (decimal)AnimalStats.birdWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.birdAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Parrot((decimal)rng.NextDouble() * (decimal)AnimalStats.birdWeightMax + (decimal)AnimalStats.birdWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.birdAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Dog((decimal)rng.NextDouble() * (decimal)AnimalStats.dogWeightMax + (decimal)AnimalStats.dogWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.dogAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Cat((decimal)rng.NextDouble() * (decimal)AnimalStats.catWeightMax + (decimal)AnimalStats.catWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.catAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Human((decimal)rng.NextDouble() * (decimal)AnimalStats.humanWeightMax + (decimal)AnimalStats.humanWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.humanAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Chameleon((decimal)rng.NextDouble() * (decimal)AnimalStats.reptileWeightMax + (decimal)AnimalStats.reptileWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.reptileAgeMax), EVERYONE_HAS_FOUR_LIMBS));
                animalList.Add(new Gecko((decimal)rng.NextDouble() * (decimal)AnimalStats.reptileWeightMax + (decimal)AnimalStats.reptileWeightMin, rng.Next((int)AnimalStats.allAgeMin, (int)AnimalStats.reptileAgeMax), EVERYONE_HAS_FOUR_LIMBS));
            }

            //TODO: Sorting animals by type. 

            while (true)
            {
                DrawMainMenu();
                SelectInMainMenu(Utilities.GetStringInput("So what do you wanna do?\n\n"));
            }
        }

        public static void DrawMainMenu()
        {
            Console.Clear();

            Console.Write(
                " === AnimalMaster 6000 MKIII === " + Environment.NewLine +
                " 1). Add Animal" + Environment.NewLine +
                " 2). Remove Animal" + Environment.NewLine +
                " 3). Show info on Animals." + Environment.NewLine +
                " 4). Check Animal functions" + Environment.NewLine +
                " 5). Exit Animalmaster 6000 MKIII" + Environment.NewLine);
        }

        public static void SelectInMainMenu(string inputString)
        {
            switch (inputString.ToLower())
            {
                case "1":
                case "add":
                case "add animal":
                    animalList.Add(AddAnimal());
                    break;
                case "2":
                case "remove":
                case "remove animal":
                    RemoveAnimal();
                    break;
                case "3":
                case "info":
                case "show info":
                case "show info on animals":
                    ShowAllAnimals();

                    Console.WriteLine("\nWhen you are done, press any key to return to the main menu.");

                    Console.ReadKey();
                    break;

                case "4":
                case "check":
                case "check animal functions":
                case "functions":

                    break;
                case "5":
                case "exit":
                case "exit animalmaster":
                case "exit animalmaster 6000 mkiii":
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static Animal AddAnimal()
        {

            Console.Clear();
            Console.WriteLine("You have seletected to add an Animal. Please follow the instructions properly.\nPress Any key to continue\n\n");
            Console.ReadKey();

            string userinput = "";
            string moreUserInput;

            while (true)
            {
                Console.Clear();

                Console.Write(
                    " Do you want to add a: " + Environment.NewLine +
                    " 1). Kolibri" + Environment.NewLine +
                    " 2). Parrot" + Environment.NewLine +
                    " 3). Dog" + Environment.NewLine +
                    " 4). Human" + Environment.NewLine +
                    " 5). Cat" + Environment.NewLine +
                    " 6). Chameleon" + Environment.NewLine +
                    " 7). Gecko" + Environment.NewLine +
                    " 8). Abort adding of animal" + Environment.NewLine);

                userinput = Utilities.GetStringInput("So what do you wanna do?\n\n");

                switch (userinput.ToLower())
                {
                    case "1":
                    case "kolibri":
                        //return new Kolibri(
                        break;
                    case "2":
                    case "parrot":
                        break;
                    case "3":
                    case "dog":
                        break;
                    case "4":
                    case "human":
                        break;
                    case "5":
                    case "cat":
                        break;
                    case "6":
                    case "chameleon":
                        break;
                    case "7":
                    case "gecko":
                        break;
                    case "8":
                    case "abort":
                        break;
                }
            }

            Console.ReadKey();

            return new Dog(1, 1, 4);

        }

        public static void ShowAllAnimals()
        {
            Console.Clear();

            int i = 0;

            foreach (Animal a in animalList)
            {
                Console.WriteLine(i + "). " + a.ToString());
                i++;
            }
        }

        public static void RemoveAnimal()
        {
            Console.Clear();
            Console.WriteLine("You have seletected to remove an Animal. Please follow the instructions properly.\nPress Any key to continue\n");
            Console.ReadKey();

            ShowAllAnimals();



            int murderInputInt = Utilities.GetIntInput("\nAll animals are being listed with a number. Please enter the number corresponding to the animal to remove it.\nJust enter a number that is not in the list to exit: ");

            try
            {
                animalList.RemoveAt(murderInputInt);
                Console.WriteLine("Congratulations. Your murder of an innocent animal was successful. Press any key to return to the main menu.");
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("You have chosen not to murder an animal today. Good for you. Press any key to return to the main menu.");
            }

        }

    }
}
