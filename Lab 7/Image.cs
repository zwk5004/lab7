using System;

namespace Lab_7
{
    public class Image : NovelElementIF
    {
        private string image;

        public Image(string image)
        {
            this.image = image;
        }
        
        public void save()
        {
            Console.WriteLine("Saving Image");
        }

        public void retrieve()
        {
            Console.WriteLine("Retrieving Image");
        }

        public void view()
        {
            Console.Write(image);
        }

        public void edit()
        {
            Console.WriteLine("Editing Image");
        }

        public void delete()
        {
            Console.WriteLine("Deleting Image");
        }
    }
}