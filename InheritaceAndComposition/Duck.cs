namespace InheritaceAndComposition
{
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
