using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class Novel : NovelIF
    {
        List<NovelIF> elements;

        public Novel(List<NovelIF> elements)
        {
            this.elements = elements;
        }

        public void save()
        {
            Console.WriteLine("Saving Novel");
        }

        public void retrieve()
        {
            Console.WriteLine("Retrieving Novel");
        }

        public void view()
        {
            foreach (NovelIF element in elements)
            {
                element.view();
            }
        }

        public void edit()
        {
            Console.WriteLine("Editing Novel");
        }

        public void delete()
        {
            Console.WriteLine("Deleting Novel");
        }
    }
}