using System;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized {0}", registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("BDTY245745");
        }
    }
}
