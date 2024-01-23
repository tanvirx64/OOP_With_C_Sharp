using System;

namespace InheritaceAndComposition
{
    ///Inheritance
    //Tight Coupling
    public class Animal { 
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public void Sleep ()
        {
            Console.WriteLine("Sleeping...");
        }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}
