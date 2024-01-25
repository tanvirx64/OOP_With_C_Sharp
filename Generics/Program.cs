using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenericList<int> numbers = new GenericList<int>();
            //GenericList<Book> books = new GenericList<Book>();
            //books.Add(new Book { });
            //numbers.Add(5);

            Nullable<float> number = new Nullable<float>();
            Console.WriteLine("Has value? : " + number.HasValue);
            Console.WriteLine("Value : " + number.GetValueOrDefault());
            
        }
    }
}
