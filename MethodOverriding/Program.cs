using System.Collections.Generic;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            //Calcualtor
            var calculator = new Calculator();

            //without params
            calculator.Add(new int[] {1,2,3,4,5});


            //with params
            calculator.AddUsingParams(new int[] {1,2,4,5});
            //or
            calculator.AddUsingParams(1,2,4,5);
        }
    }
}
