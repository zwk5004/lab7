using System.Collections.Generic;

namespace Lab_7
{
    public class Frame : CompositeNovelElement
    {
        public Frame(List<NovelElementIF> elements)
        {
            base.elements = elements;
        }
    }
}