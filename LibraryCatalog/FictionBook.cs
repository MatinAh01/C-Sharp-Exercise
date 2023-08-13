using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class FictionBook : Book
    {
        public string Genre { get; set; }
        public FictionBook(string name, string author, int page, string genre) : base(name, author, page)
        {
            Genre = genre;
        }
        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}