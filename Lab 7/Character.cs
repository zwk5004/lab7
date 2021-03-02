using System;

namespace Lab_7
{
    public class Character : NovelElementIF
    {
        private string character;

        public Character(string character)
        {
            this.character = character;
        }
        
        public void save()
        {
            Console.WriteLine("Saving Character");
        }

        public void retrieve()
        {
            Console.WriteLine("Retrieving Character");
        }

        public void view()
        {
            Console.Write(character);
        }

        public void edit()
        {
            Console.WriteLine("Editing Character");
        }

        public void delete()
        {
            Console.WriteLine("Deleting Character");
        }
    }
}