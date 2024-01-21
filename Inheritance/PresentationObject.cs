using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int height { get; set; }
        public int width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object is copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
