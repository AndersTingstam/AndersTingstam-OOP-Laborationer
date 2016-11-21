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
                new Book { Title = "Ida och Adam", Genre = "Romance", Pages = 149, Price = 49 }
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

        public void PrintWhere(List<BookFilter> filterList)
        {
            Console.WriteLine(Books
                .Where(Book => filterList
                .Where(BookFilter => BookFilter(Book).Equals())
                .Select(Book => Book.Title);
        }
    }
}
