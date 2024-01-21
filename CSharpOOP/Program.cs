using System;
namespace CSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = Person.Parse("Tarif");
            //person.SetBirthdate(new DateTime(2004, 03, 26));
            //person.Introduce("Mosh");
            //Console.WriteLine(person.GetAge());

            //Indexer
            var cookie = new HttpCookie();
            cookie["cookieName"] = "loginCookie";
            cookie.Expiry = DateTime.Today.AddDays(7);
            Console.WriteLine(cookie.Expiry);
        }
    }
}
