namespace Lab_7
{
    public class Writer
    {
        private WriterIF novel;

        public Writer(WriterIF novel)
        {
            this.novel = novel;
        }

        public WriterIF getNovel()
        {
            return this.novel;
        }
    }
}