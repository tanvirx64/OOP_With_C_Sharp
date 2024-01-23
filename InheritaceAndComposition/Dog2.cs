namespace InheritaceAndComposition
{
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
}
