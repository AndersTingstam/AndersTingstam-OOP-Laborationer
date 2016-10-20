using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_3
{
    class Menu
    {
        public static string FormatMenu(List<string> inputStringList)
        {
            string outputString = "";

            foreach(string s in inputStringList)
            {
                outputString += s;
            }

            return outputString;
        }

        public static List<string> FormatNumberedMenu(List<string>inputStringList, int counter = 0)
        {
            List<string> outputStringList = new List<string>();

            foreach (string s in inputStringList)
            {
               outputStringList.Add(String.Format(" {0}). {1}", counter.ToString(), s));
               counter++;
            }

            return outputStringList;
        }

        public static int GetListNumberInputChoice(List<string> inputStringList, string inputTitle = "", string inputPostScriptum = "\nPlease Select a number: ", int counter = 0)
        {
            int outputInt = -1;

            Console.Write(inputTitle);

            List<string> numberFormattedList = FormatNumberedMenu(inputStringList, counter);

            foreach(string s in numberFormattedList)
            {
                Console.Write(s + Environment.NewLine);
            }

            outputInt = Utilities.GetIntInput(inputPostScriptum);

            return outputInt;
        }
    }
}
