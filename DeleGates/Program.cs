using System;

namespace DeleGates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //With custom Delegate
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFiltersHandler filtersHandler = filters.ApplyBrightness;
            filtersHandler += filters.ApplyContrast;
            filtersHandler += filters.Resize;
            filtersHandler += RemoveRedEyeFilte;

            processor.Process("myPhoto.jpg", filtersHandler);


            //With Default Generic Delegate --> Action
            Action<Photo> filtersHandler2 = filters.ApplyBrightness;
            filtersHandler2 += filters.ApplyContrast;
            filtersHandler2 += filters.Resize;
            filtersHandler2 += RemoveRedEyeFilte;
            
            processor.PreProcess("myPhoto.jpg", filtersHandler2);
        }
        static void RemoveRedEyeFilte(Photo photo)
        {
            Console.WriteLine("Applying Remove Red Eye Filter ...");
        }
    }

}
