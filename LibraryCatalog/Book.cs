using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryCatalog
{
	public abstract class Book
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public int Page { get; set; }
		

		public Book(string name, string author, int page)
		{
			Name = name;
			Author = author;
			Page = page;
		}

		public abstract void GetAdditionalInfo();
		public void DisplayInfo()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Author: {Author}");
			Console.WriteLine($"Pages: {Page}");
		}

		
		
	}
}