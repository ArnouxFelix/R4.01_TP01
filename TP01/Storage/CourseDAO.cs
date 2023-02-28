using Logic;
using System.Data.SQLite;

namespace Storage
{
    public class CourseDAO : ICourseDAO
    {
        private SQLiteConnection connection;
        public CourseDAO(string fileName)
        {
            connection = new SQLiteConnection(@"DataSource=" + fileName);
        }

        public void Create(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public Course[] ListAll()
        {
            throw new NotImplementedException();
        }

        public Course Read(string code)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}