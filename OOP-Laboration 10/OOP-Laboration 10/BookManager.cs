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
        public delegate bool BookFilter(Book book);


        public void PrintWhere(BookFilter filter)
        {

        }
    }
}
