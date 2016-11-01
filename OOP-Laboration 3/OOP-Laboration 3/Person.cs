using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Laboration_3
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string inputName = "DefaultusMaximus")
        {
            Name = inputName;
        }
    }
}