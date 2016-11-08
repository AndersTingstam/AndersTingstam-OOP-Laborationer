using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Utils
    {
        #region Utility Methods

        static public string GetStringInput(string WhatToWriteToUser)
        {
            Console.Write(WhatToWriteToUser);

            while (true)
            {
                try
                {
                    string outputString = Console.ReadLine();
                    if (outputString.ToLower() == "exit" || outputString.ToLower() == "quit")
                        Environment.Exit(0);
                    else
                        return outputString;
                }

                catch (Exception e)
                {
                    Console.WriteLine("I have no clue how we ended up here. But by now I'm too afraid to ask");
                }
            }
        }

        static public int GetIntInput(string WhatToWriteToUser)
        {
            while (true)
            {
                try
                {
                    return Int32.Parse(GetStringInput(WhatToWriteToUser));
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Foo! You were supposed to enter a number! Nothing else.");
                }

                catch (Exception e)
                {
                    Console.WriteLine("I have no clue how we ended up here. But by now I'm too afraid to ask");
                }
            }
        }

        #endregion
    }
}
