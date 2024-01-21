using System;

namespace CSharpOOP
{
    public class Person
    {
        private string _name;
        private DateTime _birthdate;
        public Person(string name = "")
        {
            _name = name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        public double GetAge()
        {
            return (DateTime.Today - _birthdate).Days/365;
        }

        public void Introduce(string to)
        { 
            Console.WriteLine("Hi {0}, I am {1}", to, _name);
        }
        public static Person Parse(string name)
        {
            var person = new Person();
            person._name = name;
            return person;
        }
    }
}
