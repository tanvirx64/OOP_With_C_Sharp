using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    internal partial class Program
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
            calculator.Add(new int[] { 1, 2, 3, 4, 5 });


            //with params
            calculator.AddUsingParams(new int[] { 1, 2, 4, 5 });
            //or
            calculator.AddUsingParams(1, 2, 4, 5);

            //Point
            try
            {
                var point = new Point(0, 0);
                point.Move(200, 300);
                Console.WriteLine("{0},{1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An Error Occured");
            }


            //use of out modifier
            int number;
            var result = int.TryParse(Console.ReadLine(), out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
            
        }
    }
}
