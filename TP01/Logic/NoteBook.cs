namespace Logic
{
    public class NoteBook
    {
        private ICourseDAO courseDAO;
        private IExamDao examDAO;
        public NoteBook(ICourseDAO courseDAO)
        {
            this.courseDAO = courseDAO;
        }

        /// <summary>
        /// Demande au DAO une liste de toutes les matières
        /// </summary>
        /// <returns>Renvoie un Enumerable de matières</returns>
        public IEnumerable<Course> ListCourses()
        {
            return this.courseDAO.ListAll();
        }


        /// <summary>
        /// Créer une nouvelle matière
        /// </summary>
        /// <returns></returns>
        public Course NewCourse()
        {
            return new Course(courseDAO);
        }

        /// <summary>
        /// Demande au DAO de supprimer une matière de la BDD
        /// </summary>
        /// <param name="course">la matière à supprimer</param>
        public void RemoveCourse(Course course)
        {
            courseDAO.Delete(course);
        }

        /// <summary>
        /// Demande au DAO de exam de créer un exam dans la BDD
        /// </summary>
        /// <param name="exam"></param>
        public void CreateExam(Exam exam)
        {
            examDAO.Create(exam);
        }

        /// <summary>
        /// Demande au DAO une liste de tous les exam
        /// </summary>
        /// <returns>Renvoie un Enumerable d'Exam</returns>
        public IEnumerable<Exam> GetExams()
        {
            return this.examDAO.ListAll();
        }
    }
}