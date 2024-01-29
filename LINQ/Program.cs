using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book { Id = 1, Name = "Basics of C#" });
            books.Add(new Book { Id = 2, Name = "Basics of C" });
            books.Add(new Book { Id = 3, Name = "Basics of C++" });

            var lastBook = books.LastOrDefault();

            Console.WriteLine(lastBook.Name);
        }
    }
}
