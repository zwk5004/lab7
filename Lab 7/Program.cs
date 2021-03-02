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
            LineOfText lineOfText1 = new LineOfText();
            lineOfText1.add(character1);
            lineOfText1.add(character2);
            lineOfText1.add(character3);
            lineOfText1.add(character4);
            lineOfText1.add(character5);
            
            Column column = new Column();
            column.add(lineOfText1);
            novelElements.Add(column);

            Character character6 = new Character("4");
            Character character7 = new Character("2");
            Character character8 = new Character("1");
            LineOfText lineOfText2 = new LineOfText();
            lineOfText2.add(character6);
            lineOfText2.add(character7);
            lineOfText2.add(character8);
            lineOfText2.add(new LineOfText());
            Column column2 = new Column();
            column2.add(lineOfText2);
            Frame frame = new Frame();
            frame.add(column2);
            novelElements.Add(frame);

            Novel novel = new Novel(novelElements);
            Writer writer = new Writer(novel);
            writer.getNovel().view();
        }
    }
}