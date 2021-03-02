using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class Frame : CompositeNovelElement
    {
        public override void add(NovelElementIF novel)
        {
            if (novel.GetType().IsInstanceOfType(typeof(Frame)))
            {
                throw new Exception("Frame cannot contain Frame");
            }

            base.elements.Add(novel);
        }
    }
}