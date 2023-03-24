using Logic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class ExamDAO : BaseDAO, IExamDao
    {
        public ExamDAO(string fileName) : base(fileName)
        {
        }

        public void Create(Exam exam)
        {
            ExecuteNonQuery("INSERT INTO Exam(Score,Teacher,DateExam,Coef,CourseCode) VALUES("+exam.Score + ",'" +exam.Teacher + "'," +exam.DateExam.ToFileTime() + "," +exam.Coef + ",'" +exam.Course.Code + "')");
        }

        public IEnumerable<Exam> ListAll()
        {
            Connection.Open();
            SQLiteDataReader reader = ExecuteQuery("SELECT * FROM Exam");
            List<Exam> exams = new List<Exam>();
            using (reader)
            {
                while (reader.Read())
                {
                    exams.Add(Reader2Exam(reader));
                }
            }
            Connection.Close();
            return exams;
        }

        private Exam Reader2Exam(SQLiteDataReader reader)
        {
            CourseDAO courseDAO = new CourseDAO(FileName);
            Course course = courseDAO.Read(reader["CourseCode"].ToString());
            Exam exam = new Exam(course);
            exam.Teacher = reader["Teacher"].ToString();
            exam.Coef = Convert.ToInt32(reader["Coef"].ToString());
            exam.Score = float.Parse(reader["Score"].ToString());
            exam.DateExam = DateTime.FromFileTime(Convert.ToInt64(reader["DateExam"]));
            return exam;
        }
    }
}
