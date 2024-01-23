namespace InheritaceAndComposition
{
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
}
