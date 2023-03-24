using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Exam
    {
        private double score;
        private string teacher;
        private DateTime dateExam = DateTime.Now;
        private int coef = 1;
        private Course course;

        /// <summary>
        /// Note de l'étudiant
        /// </summary>
        public double Score {
            get { return score; }
            set { if(value >= 0 && value <= 20) score = value; }
        }
        /// <summary>
        /// Nom de l'enseignant
        /// </summary>
        public string Teacher { get => teacher; set => teacher = value; }
        /// <summary>
        /// Date de l'examen (Ne peut pas être dans le futur)
        /// </summary>
        public DateTime DateExam {
            get { return dateExam; }
            set { if((DateTime.Now-value).TotalMilliseconds > 0) dateExam = value; }
        }
        /// <summary>
        /// Coefficient de l'examen (Doit être compris entre 1 et 100)
        /// </summary>
        public int Coef {
            get { return coef; }
            set { if(value >= 1 && value <= 100) coef = value; } 
        }

        public Course Course { get => course; set => course = value; }

        public Exam(Course c)
        {
            this.Course = c;
        }
    }
}
