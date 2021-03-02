using System.Collections.Generic;

namespace Lab_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<NovelIF> novelElements = new List<NovelIF>();
            
            Character character1 = new Character("S");
            Character character2 = new Character("W");
            Character character3 = new Character("E");
            Character character4 = new Character("N");
            Character character5 = new Character("G");
            List<NovelElementIF> characters1 = new List<NovelElementIF>();
            characters1.Add(character1);
            characters1.Add(character2);
            characters1.Add(character3);
            characters1.Add(character4);
            characters1.Add(character5);
            LineOfText lineOfText1 = new LineOfText(characters1);
            Column column = new Column(new List<NovelElementIF>() {lineOfText1});
            novelElements.Add(column);

            Character character6 = new Character("4");
            Character character7 = new Character("2");
            Character character8 = new Character("1");
            List<NovelElementIF> characters2 = new List<NovelElementIF>();
            characters2.Add(character6);
            characters2.Add(character7);
            characters2.Add(character8);
            LineOfText lineOfText2 = new LineOfText(characters2);
            Column column2 = new Column(new List<NovelElementIF>() {lineOfText2});
            Frame frame = new Frame(new List<NovelElementIF>() {column2});
            novelElements.Add(frame);

            Novel novel = new Novel(novelElements);
            Writer writer = new Writer(novel);
            writer.getNovel().view();
        }
    }
}