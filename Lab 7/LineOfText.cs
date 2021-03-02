using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class LineOfText : CompositeNovelElement
    {
        public LineOfText(List<NovelElementIF> elements)
        {
            base.elements = elements;
        }
    }
}