namespace Logic
{
    public class NoteBook
    {
        private ICourseDAO courseDAO;
        public NoteBook(ICourseDAO courseDAO)
        {
            this.courseDAO = courseDAO;
        }

        public IEnumerable<Course> ListCourses()
        {
            return this.courseDAO.ListAll();
        }

        public Course NewCourse()
        {
            return new Course(courseDAO);
        }

        public void RemoveCourse(Course course)
        {
            courseDAO.Delete(course);
        }
    }
}