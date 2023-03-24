using Logic;
using System.Data.SQLite;

namespace Storage
{
    public class CourseDAO :BaseDAO, ICourseDAO
    {
        /// <summary>
        /// Constructeur de CourseDAO
        /// </summary>
        /// <param name="fileName">chemin de la BDD</param>
        public CourseDAO(string fileName):base(fileName)
        {
        }

        public void Create(Course course)
        {
            ExecuteNonQuery("INSERT INTO Course(Code,Name,Weight) VALUES('" + course.Code + "','" + course.Name + "'," + course.Weight.ToString() + ")");
        }

        public void Delete(Course course)
        {
            ExecuteNonQuery("DELETE FROM Course WHERE code='" + course.Code + "'");
        }

        public IEnumerable<Course> ListAll()
        {
            Connection.Open();
            SQLiteDataReader reader = ExecuteQuery("SELECT * FROM Course");
            List<Course> courses = new List<Course>();
            using (reader)
            {
                while (reader.Read())
                {
                    courses.Add(Reader2Course(reader));
                }
            }
            Connection.Close();
            return courses;
        }

        public Course Read(string code)
        {
            Course course;
            Connection.Open();
            course = Reader2Course(ExecuteQuery("SELECT * FROM Course WHERE Code ='" + code + "'"));
            Connection.Close();
            return course;
        }

        public void Update(Course course)
        {
            ExecuteNonQuery("UPDATE Course SET Name ='" + course.Name + "',Weight=" + course.Weight.ToString() + " WHERE Code='" + course.Code + "'");
        }

        private Course Reader2Course(SQLiteDataReader reader)
        {
            Course prof = new Course(this,true);
            prof.Code = reader["Code"].ToString();
            prof.Name = reader["Name"].ToString();
            prof.Weight = Convert.ToInt32(reader["Weight"]);
            return prof;
        }

    }
}