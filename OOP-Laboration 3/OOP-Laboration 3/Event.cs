using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_3
{
    public abstract class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        public Event()
        {
            Type = "Event";
            Name = "Defaultus Eventus";
            Date = RandomiseDate();
        }

        public string WriteType()
        {
            return this.GetType().Name;
        }

        public void DoShit()
        {
            Console.Write("This Event is doing something.");
        }

        private DateTime RandomiseDate()
        {
            DateTime tempDate = new DateTime();
            tempDate = DateTime.Now;

            tempDate = tempDate.AddYears(RandomShit.rng.Next(0, 5));
            tempDate = tempDate.AddMonths(RandomShit.rng.Next(-6, 6));
            tempDate = tempDate.AddDays((RandomShit.rng.NextDouble() - 0.5) * 180);
            tempDate = tempDate.AddHours((RandomShit.rng.NextDouble() - 0.5) * 12);

            return tempDate;
        }

        public string RandomiseName()
        {
            switch(this.Type)
            {
                case "Film": return RandomShit.filmNames.ElementAt(RandomShit.rng.Next(0, RandomShit.filmNames.Count));
                case "Concert": return RandomShit.concertNames.ElementAt(RandomShit.rng.Next(0, RandomShit.concertNames.Count));
                case "Festival": return RandomShit.festivalNames.ElementAt(RandomShit.rng.Next(0, RandomShit.festivalNames.Count));

                default: return "LoL";
               
            }
        }

        public override string ToString()
        {
            return String.Format("{0,-40} {1,-8} {2,40}", this.Name, this.Type, this.Date);
        }
    }
}