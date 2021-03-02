using System;
using System.Collections.Generic;

namespace Lab_7
{
    public class LineOfText : CompositeNovelElement
    {
        public override void add(NovelElementIF novel)
        {
            if (novel.GetType() == typeof(LineOfText))
            {
                throw new Exception("LineOfText cannot contain LineOfText");
            }

            base.elements.Add(novel);
        }
    }
}