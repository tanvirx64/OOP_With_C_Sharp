using System;

namespace DeleGates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFiltersHandler filtersHandler = filters.ApplyBrightness;
            filtersHandler += filters.ApplyContrast;
            filtersHandler += filters.Resize;
            filtersHandler += RemoveRedEyeFilte;

            processor.Process("myPhoto.jpg", filtersHandler);
        }
        static void RemoveRedEyeFilte(Photo photo)
        {
            Console.WriteLine("Applying Remove Red Eye Filter ...");
        }
    }

}
