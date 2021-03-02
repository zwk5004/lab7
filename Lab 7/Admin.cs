namespace Lab_7
{
    public class Admin
    {
        private AdminIF novel;

        public Admin(AdminIF novel)
        {
            this.novel = novel;
        }

        public AdminIF getNovel()
        {
            return this.novel;
        }
    }
}