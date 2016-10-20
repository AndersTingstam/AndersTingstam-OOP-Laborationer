using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_3
{
    class Runtime
    {
        public const int NUMBER_OF_RANDOM_EVENTS = 50;
        List<Booking> bookingList = new List<Booking>();
        List<Event> eventList = new List<Event>();

        public void StartShit()
        {
            for (int i = 0; i < NUMBER_OF_RANDOM_EVENTS; i++)
            {
                eventList.Add(new Film());
                eventList.Add(new Festival());
                eventList.Add(new Concert());
            }

            //We have different type of events. Let's not cast them as Events.

            List<string> listTest = eventList
                .Where(Event => string.Equals(Event.Type, "Concert"))
                .Select(Event => Event.Name)
                .ToList();

            int inputInt = Menu.GetListNumberInputChoice(listTest);

            Console.ReadKey();
        }
    }
}
