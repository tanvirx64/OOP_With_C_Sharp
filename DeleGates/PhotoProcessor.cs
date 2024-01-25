using System;

namespace DeleGates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFiltersHandler(Photo photo);
        public void Process(string path, PhotoFiltersHandler filterHandler)
        {
            var photo = Photo.Load(path);
            
            filterHandler(photo);

            photo.Save();
        }

        public void PreProcess(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }

}
