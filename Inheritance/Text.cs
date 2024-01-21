using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontWeight { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("Hyper link is added to "+ url);
        }
    }
}
