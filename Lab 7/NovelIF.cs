using System.Collections.Generic;

namespace Lab_7
{
    public interface NovelIF : AdminIF, WriterIF, EditorIF
    {
        void save();
        void retrieve();
        void view();
        void edit();
        void delete();
    }
}