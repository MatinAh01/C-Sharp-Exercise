using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    class Library
    {
        public static void DisplayBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("----------");
                book.DisplayInfo();
                book.GetAdditionalInfo();
                Console.WriteLine("----------");
            }
        }
    }
}