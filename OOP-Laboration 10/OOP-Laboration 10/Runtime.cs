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

            Console.WriteLine("\n === Romance Novels === \n\n");

            bookManager.PrintWhere(isRomanceFilter && isNovelFilter);

            Console.ReadKey();

        }

    }
}
