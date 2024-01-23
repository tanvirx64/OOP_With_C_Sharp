using System;

namespace InheritaceAndComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance
            Person person = new Person();
            Dog dog = new Dog();

            person.Read();
            person.Sleep();

            dog.WalkWithFrourPods();
            dog.Sleep();

            //Composition
            Person2 person2 = new Person2(new Animal());
            Dog2 dog2 = new Dog2(new Animal(), new AnimalWithFrourLegs());
            Duck duck = new Duck(new Animal(), new Swimable());

            person2.EatRice();

            dog2.SleepAtDay();
            dog2.Walk();

            duck.Swim();
            duck.Sleep();
            duck.Eat();
            duck.Walk();

        }
    }
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
    public class Person : Animal {
        public void Read()
        {
            Console.WriteLine("Reading...");
        }
    }
    public class Dog : Animal { 
        public void WalkWithFrourPods()
        {
            Console.WriteLine("Walking with 4 legs ...");
        }
    }

    ///Compsition <summary>
    /// Compsition
    /// </summary>
    ///  Loose Coupling

    public class Swimable
    {
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }

    public class AnimalWithFrourLegs
    {
        public void WalkWithFourLegs()
        {
            Console.WriteLine("Walking with Four Legs...");
        }
    }
    public class Person2
    {
        private readonly Animal _animal;
        public Person2(Animal animal)
        {
            this._animal = animal;
        }
        public void EatRice() {
            _animal.Eat();
        }
    }

    public class Dog2
    {
        private readonly Animal _animal;
        private readonly AnimalWithFrourLegs _walkWithFourLegs;
        public Dog2(Animal animal, AnimalWithFrourLegs walkWithFourLegs)
        {
            this._animal = animal;
            this._walkWithFourLegs = walkWithFourLegs;
        }
        public void SleepAtDay() {
            _animal.Sleep();
        }
        public void Walk() {
            _walkWithFourLegs.WalkWithFourLegs();
        }
    }

    public class Duck
    {
        private readonly Animal _animal;
        private readonly Swimable _swimable;
        public Duck(Animal animal, Swimable swimable)
        {
            _animal = animal;
            _swimable = swimable;
        }
        public void Swim() {
            _swimable.Swim();
        }

        public void Walk() {
            _animal.Walk();
        }
        public void Eat() {
            _animal.Eat();
        }

        public void Sleep()
        {
            _animal.Sleep();
        }
    }
}
