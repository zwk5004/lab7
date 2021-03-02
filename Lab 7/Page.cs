using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class Page : CompositeNovelElement
    {
        public override void add(NovelElementIF novel)
        {
            if (novel.GetType().IsInstanceOfType(typeof(Page)))
            {
                throw new Exception("Page cannot contain Page");
            }

            base.elements.Add(novel);
        }
    }
}