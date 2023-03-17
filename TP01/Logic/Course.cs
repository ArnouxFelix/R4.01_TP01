using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Course
    {
        private ICourseDAO courseDAO;
        private bool alreadyExist;

        private string code;

        private string name;

        private int weight;

        /// <summary>
        /// Clé Primaire
        /// </summary>
        public string Code { get => code; set => code = value; }
        /// <summary>
        /// Nom de la matière
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Coefficient de la matière
        /// </summary>
        public int Weight { get => weight; set => weight = value; }
        public bool AlreadyExist { get => alreadyExist; set => alreadyExist = value; }

        /// <summary>
        /// Donne l'ordre de mettre à jour dans la BDD
        /// </summary>
        public void Update()
        {
            if (alreadyExist)
            {
                courseDAO.Update(this);
            }
            else
            {
                courseDAO.Create(this);
            }
        }

        /// <summary>
        /// Constructeur de Course
        /// </summary>
        /// <param name="dao"></param>
        public Course(ICourseDAO dao, bool exist = false)
        {
            courseDAO = dao;
            AlreadyExist = exist;
        }

        public override string ToString()
        {
            return String.Format("Code : "+this.Code+"   Name : "+this.Name+"   Weight : "+this.Weight.ToString());
        }
    }
}
