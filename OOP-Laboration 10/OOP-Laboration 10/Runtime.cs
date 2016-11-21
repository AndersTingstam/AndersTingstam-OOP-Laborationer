using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_10
{
    class Runtime
    {
        public void StartShit()
        {
            BookManager bookManager = new BookManager();

            BookFilter isShortStoryFilter = BookFilters.IsShortStory;
            BookFilter isNovelFilter = BookFilters.IsNovel;
            BookFilter isFantasyFilter = BookFilters.IsGenreFantasy;
            BookFilter isMysteryFilter = BookFilters.IsGenreMystery;
            BookFilter isRomanceFilter = BookFilters.IsGenreRomance;
            BookFilter isCheapFilter = BookFilters.IsCheap;
            BookFilter isExpensiveFilter = BookFilters.IsExpensive;

            Console.WriteLine(" === Cheap Books === \n\n");

            bookManager.PrintWhere(isCheapFilter);


            //Combining filters
            Console.WriteLine("\n\n === Fantasy === \n");

            bookManager.PrintWhere(new List<BookFilter> { isFantasyFilter });

            Console.WriteLine("\n\n === Cheap Novels === \n");

            bookManager.PrintWhere(new List<BookFilter> { isCheapFilter, isNovelFilter });

            Console.WriteLine("\n\n === Cheap Mystery Novels === \n");

            bookManager.PrintWhere(new List<BookFilter> { isCheapFilter, isMysteryFilter, isNovelFilter });

            Console.WriteLine("\n\n === Expensive Fantasy Shortstories === \n");

            bookManager.PrintWhere(new List<BookFilter> { isExpensiveFilter, isFantasyFilter, isShortStoryFilter });

            //TODO : Write user menu interface where they can add and remove filters freely from the list of filters.

            Console.ReadKey();
        }

    }
}
