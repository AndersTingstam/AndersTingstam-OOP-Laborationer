using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laboration_10
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>
            {
                new Book { Title = "Harry Potter and the Goblet of Fire", Genre = "Fantasy", Pages = 458, Price = 399 },
                new Book { Title = "Eragon", Genre = "Fantasy", Pages = 375, Price = 259 },
                new Book { Title = "Morden i Midsomer", Genre = "Mystery", Pages = 89, Price = 59 },
                new Book { Title = "Eva och Adam", Genre = "Romance", Pages = 149, Price = 49 },
                new Book { Title = "Harry Potter and the Sorcerer's Stone", Genre = "Fantasy", Pages = 253, Price = 49 },
                new Book { Title = "It was the Butler who did it!", Genre = "Mystery", Pages = 159, Price = 29 }
            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (Book book in Books)
            {
                if(filter(book))
                    Console.WriteLine(book.Title);
            }
        }

        //Overloaded method with possibility to take a list of filters.
        public void PrintWhere(List<BookFilter> filterList)
        {
            List<string> tempList = Books
                .Where(book => filterList
                    .TrueForAll(filter => filter(book)))
                .Select(book => book.Title)
                .ToList();

            if (tempList.Count == 0)
            {
                Console.WriteLine("None");
            }

            else
            {
                foreach (string s in tempList)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
