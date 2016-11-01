using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_3
{
    class Runtime
    {
        public const int NUMBER_OF_RANDOM_EVENTS = 15;
        List<Booking> bookingList = new List<Booking>();
        List<Event> eventList = new List<Event>();
        Person currentUser = new Person();

        Menu mainMenu = new Menu("Welcome to Bookmaster 5000.\n\n", "\nPlease Select a number: ") { " Manage bookings", " Upcoming Events", " Exit Bookmaster 5000"};
        Menu eventInformationMenu = new Menu("Upcoming events sorted by date.\nPlease Specify what event you want more info on\n\n", "\nPlease Select a number: ") { " Films", " Festivals", " Concerts", " All events", " Back" };
        Menu bookEventMenu = new Menu("Event Management menu.\nPlease specify what type of event you want to book\n\n", "\nPlease Select a number: ") { " Films", " Festivals", " Concerts", " View booked events "," Back" };

        public void StartShit()
        {
            for (int i = 0; i < NUMBER_OF_RANDOM_EVENTS; i++)
            {
                eventList.Add(new Film());
                eventList.Add(new Festival());
                eventList.Add(new Concert());
            }

            currentUser.Name = Utilities.GetStringInput("\nPlease enter your name: ");

            while (true)
            {
                Console.Clear();
                int inputInt = mainMenu.GetListNumberInputChoice();

                switch (inputInt)
                {
                    case 1: manageEventMenu(); break;
                    case 2: eventMenuInformation();  break;
                    case 3: Environment.Exit(0); break;
                }
            }
        }

        public int manageEventMenu()
        {

            while (true)
            {
                Console.Clear();
                int inputInt = bookEventMenu.GetListNumberInputChoice();
                Console.Clear();

                int inputInt2;

                switch (inputInt)
                {
                    
                    case 1:
                        inputInt2 = Menu.GetListNumberInputChoice(FormatLinQSearch("Film"));
                        bookingList.Add(new Booking(currentUser, GetEventFromList("Film", inputInt2)));
                        break;

                    case 2:
                        inputInt2 = Menu.GetListNumberInputChoice(FormatLinQSearch("Festival"));
                        bookingList.Add(new Booking(currentUser, GetEventFromList("Festival", inputInt2)));
                        break;

                    case 3:
                        inputInt2 = Menu.GetListNumberInputChoice(FormatLinQSearch("Concert"));
                        bookingList.Add(new Booking(currentUser, GetEventFromList("Concert", inputInt2)));
                        break;

                    case 4:
                        Console.Write(Menu.FormatMenu(bookingList
                            .Where(Booking => string.Equals(Booking.Person.Name, currentUser.Name))
                            .OrderBy(Booking => Booking.Event.Date)
                            .Select(Booking => Booking.Event.ToString())
                            .ToList()));
                        Console.Write("\n\nPress any key to return to the earlier menu.");
                        Console.ReadKey();
                        break;
                    case 5: return 0;
                }
            }
        }

        public int eventMenuInformation()
        {
            while (true)
            {
                Console.Clear();
                int inputInt = eventInformationMenu.GetListNumberInputChoice();
                Console.Clear();

                switch (inputInt)
                {
                    case 1:
                        Console.Write(Menu.FormatMenu(FormatLinQSearch("Film")));
                        Console.Write("\n\nPress any key to return to the earlier menu.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write(Menu.FormatMenu(FormatLinQSearch("Festival")));
                        Console.Write("\n\nPress any key to return to the earlier menu.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write(Menu.FormatMenu(FormatLinQSearch("Concert")));
                        Console.Write("\n\nPress any key to return to the earlier menu.");
                        Console.ReadKey();
                        break;

                    case 4: Console.Write(Menu.FormatMenu(eventList
                            .OrderBy(Event => Event.Date)
                            .Select(Event => Event.ToString())
                            .ToList()));
                        Console.Write("\n\nPress any key to return to the earlier menu.");
                        Console.ReadKey();
                        break;

                    case 5: return 0;
                }
            }
        }

        public List<string> FormatLinQSearch(string inputWhereEquals)
        {
            return eventList
                            .Where(Event => string.Equals(Event.Type, inputWhereEquals))
                            .OrderBy(Event => Event.Date)
                            .Select(Event => Event.ToString())
                            .ToList();
        }

        public Event GetEventFromList(string inputEventType, int inputIntSelected)
        {
            List<Event> tempList = eventList
                            .Where(Event => string.Equals(Event.Type, inputEventType))
                            .OrderBy(Event => Event.Date)
                            .Select(Event => Event)
                            .ToList();

            return tempList.ElementAt(inputIntSelected - 1);
        }

        
    }
}
