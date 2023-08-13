using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class NonFictionBook : Book
    {
        public string Topic { get; set; }
        public NonFictionBook(string name, string author, int page, string topic) : base(name, author, page)
        {
            Topic = topic;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Topic: {Topic}");
        }
    }   

}