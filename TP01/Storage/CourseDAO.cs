using Logic;
using System.Data.SQLite;

namespace Storage
{
    public class CourseDAO : ICourseDAO
    {
        private SQLiteConnection connection;
        /// <summary>
        /// Constructeur de CourseDAO
        /// </summary>
        /// <param name="fileName">chemin de la BDD</param>
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

        public IEnumerable<Course> ListAll()
        {
            connection.Open();
            List<Course> courses = new List<Course>();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Course";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    courses.Add(Reader2Course(reader));
                }
            }
            connection.Close();
            return courses;
        }

        public Course Read(string code)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }

        private Course Reader2Course(SQLiteDataReader reader)
        {
            Course prof = new Course(this);
            prof.Code = reader["Code"].ToString();
            prof.Name = reader["Name"].ToString();
            prof.Weight = Convert.ToInt32(reader["Weight"]);
            return prof;
        }

    }
}