namespace MethodOverriding
{
    public class Calculator
    {
        public int Add(int[] numbers) {
            var sum = numbers[0];
            return sum;
            //calcualtor.Add(new int[]{1,2,3,4});
        }

        public int AddUsingParams(params int[] number)
        {
            //define here
            return 0;
            //calcutaor.Add(1,2,3,4);
        }
    }
}
