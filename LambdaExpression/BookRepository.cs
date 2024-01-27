using System.Collections.Generic;

namespace LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>{
                new Book() { Id = 1, Title="Introduction to C#", Price = 88.50M },
                new Book() { Id = 2, Title="Introduction to JavaScript", Price = 110.50M },
                new Book() { Id = 3, Title="Introduction to SQL", Price = 99.50M },
            };
        }
    }
}
