using System;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  args => expression
            // (arg1, arg2) => expression
            // () => expression

            //Func<int, int> square = s => s * s;
            //const int factor = 5;
            //Func<int, int> multiplier = number => number * factor;

            //Console.WriteLine(square(5));
            //Console.WriteLine(multiplier(5));

            var books = new BookRepository().GetBooks();


            var cheapBooks = books.FindAll(IsCheaperThan100USD);    //without lambda expression
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


            cheapBooks = books.FindAll(b => b.Price < 100);  //with lambda expression
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


        }

        public static bool IsCheaperThan100USD(Book book)
        {
            return book.Price < 100;
        }
       
    }
}
