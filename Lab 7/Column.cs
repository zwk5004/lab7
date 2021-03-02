using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class Column : CompositeNovelElement
    {
        public override void add(NovelElementIF novel)
        {
            if (novel.GetType().IsInstanceOfType(typeof(Column)))
            {
                throw new Exception("Column cannot contain Column");
            }

            base.elements.Add(novel);
        }
    }
}