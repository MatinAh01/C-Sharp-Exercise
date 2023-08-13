using System;

namespace LibraryCatalog
{
    class Program
    {
        static void Main()
        {

            Book[] catalog = new Book[]
            {
            new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
            new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
            new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
            new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help")
            };
            Library.DisplayBooks(catalog);
        }
    }
}
