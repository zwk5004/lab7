using System;
using System.Collections.Generic;

namespace Lab_7
{
    public abstract class CompositeNovelElement : NovelElementIF
    {
        protected List<NovelElementIF> elements = new List<NovelElementIF>();

        public abstract void add(NovelElementIF novel);

        public void save()
        {
            Console.WriteLine("Saving Composite Element");
        }

        public void retrieve()
        {
            Console.WriteLine("Retrieving Composite Element");
        }

        public void view()
        {
            foreach (NovelElementIF element in elements)
            {
                element.view();
            }
        }

        public void edit()
        {
            Console.WriteLine("Editing Composite Element");
        }

        public void delete()
        {
            Console.WriteLine("Deleting Composite Element");
        }
    }
}