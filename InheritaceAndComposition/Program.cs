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
}
