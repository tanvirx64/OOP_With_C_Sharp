using System;

namespace MethodOverriding
{
    public class Circle : Shape {
        public sealed override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
