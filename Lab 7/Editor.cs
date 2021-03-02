namespace Lab_7
{
    public class Editor
    {
        private EditorIF novel;

        public Editor(EditorIF novel)
        {
            this.novel = novel;
        }

        public EditorIF getNovel()
        {
            return this.novel;
        }
    }
}