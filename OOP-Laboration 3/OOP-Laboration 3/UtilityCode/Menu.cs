using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_3
{
    class Menu : List<string>
    {

        #region Properties

        public string Header { get; set; }

        public string Footer{ get; set; }

        public int Counter { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Header and Footer are declared as parameters. Body is added as a List&lt;string&gt;.
        /// </summary>
        public Menu(string inputHeader = "", string inputFooter = "", int inputCounter = 1)
        {
            Header = inputHeader;
            Footer = inputFooter;
            Counter = inputCounter;
        }

        #endregion

        #region Instance Methods

        public string FormatMenu()
        {
            return FormatMenu(this);
        }

        public List<string> FormatNumberedMenu()
        {
            return FormatNumberedMenu(this, this.Counter);
        }


        public int GetListNumberInputChoice()
        {
            return GetListNumberInputChoice(this, this.Header, this.Footer, this.Counter);
        }

        #endregion

        #region Static Methods

        public static string FormatMenu(List<string> inputStringList)
        {
            string outputString = "";

            foreach(string s in inputStringList)
            {
                outputString += s + Environment.NewLine;
            }

            return outputString;
        }

        public static List<string> FormatNumberedMenu(List<string>inputStringList, int counter = 1)
        {
            List<string> outputStringList = new List<string>();

            foreach (string s in inputStringList)
            {
               outputStringList.Add(String.Format(" {0}). {1}", counter.ToString(), s));
               counter++;
            }

            return outputStringList;
        }

        public static int GetListNumberInputChoice(List<string> inputStringList, string inputTitle = "", string inputPostScriptum = "\nPlease Select a number: ", int counter = 1)
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

        #endregion
    }
}
