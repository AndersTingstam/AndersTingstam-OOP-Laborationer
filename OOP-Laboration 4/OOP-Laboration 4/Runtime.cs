using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace OOP_Laboration_4
{
    class Runtime
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        public Menu mainMenu = new Menu("Bosse's Cars 'n' Bikes. \n", "\nPlease select an action.\nWrite exit to quit the program.\n\n : ") { "Add vehicle.", "List vehicles and/or remove vehicles" };
        public Menu addVehicleMenu = new Menu("Add a vehicle.\n", "\nPlease select an action.\nWrite exit to quit the program.\n\n : ") { "Add car", "Add bike", "Back" }; 

        //Might just need to make a direct listing here.
        //public Menu removeMenu = new Menu(" Remove a vehicle.\n", " Please select an action.\n Write exit to quit the program.\n\n") { "Remove , "Back" };

        public void Start()
        {
            fillLists();

            while (true)
            {
                Console.Clear();

                switch (mainMenu.GetListNumberInputChoice())
                {
                    case 1: addVehicleMenuMethod(); break;
                    case 2: listRemoveVehicleMenuMethod(); break;
                }

            }

        }

        public int addVehicleMenuMethod()
        {
            Console.Clear();

            while (true)
            {
                switch (addVehicleMenu.GetListNumberInputChoice())
                {
                    case 1: break;
                    case 2: break;
                    case 3: return 0;
                }
            }
        }

        public int listRemoveVehicleMenuMethod()
        {
            Console.Clear();
            int tempInt = Menu.GetListNumberInputChoice(vehicleList
                .OrderBy(Vehicle => Vehicle.Type)
                .Select(Vehicle => Vehicle.ToString())
                .ToList()
                ,"Select a vehicle you want to remove from the list.\n\n"
                ,"\n\nIf you do not want to remove a vehicle, enter a number outside the list.\n\n : ");

            try
            {
                vehicleList.RemoveAt(tempInt - 1);
            }
            catch(Exception e)
            {

            }

            return 0;
        }



        #region Filling Methods

        public void fillLists()
        {
            vehicleList.Add(new Car { Brand = "BMW", IsUsed = false, Model = "GT500", Price = 500000 });
            vehicleList.Add(new Car { Brand = "Ford", IsUsed = false, Model = "Viper", Price = 1000000 });
            vehicleList.Add(new Car { Brand = "Volvo", IsUsed = true, Model = "240", Price = 20000 });

            vehicleList.Add(new Motorcycle { Brand = "Harley Davidson", IsUsed = false, Model = "Big Bad American", Price = 699999 });
            vehicleList.Add(new Motorcycle { Brand = "Puch", IsUsed = true, Model = "Dakota", Price = 15000 });
        }

        #endregion

    }
}
