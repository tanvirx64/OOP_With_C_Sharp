using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Circle : Shape {
        public sealed override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Canvas { 
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(Shape shape in shapes)
            {
                shape.Draw();
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
