using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas { 
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(Shape shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}
