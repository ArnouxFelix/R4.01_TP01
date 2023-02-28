namespace Logic
{
    public class NoteBook
    {
        private ICourseDAO courseDAO;
        public NoteBook(ICourseDAO courseDAO)
        {
            this.courseDAO = courseDAO;
        }
    }
}