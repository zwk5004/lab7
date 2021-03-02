using System.Collections.Generic;

namespace Lab_7
{
    public class Column : CompositeNovelElement
    {
        public Column(List<NovelElementIF> elements)
        {
            base.elements = elements;
        }
    }
}