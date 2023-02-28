using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ICourseDAO
    {
        /// <summary>
        /// Créer une Course dans la BDD
        /// </summary>
        /// <param name="course"></param>
        public void Create(Course course);

        /// <summary>
        /// Lit une Course depuis la base de donnée à partir de sa PK
        /// </summary>
        /// <param name="code">la PK de la Course</param>
        /// <returns>la Course de la BDD dont la PK est code</returns>
        public Course Read(string code);

        /// <summary>
        /// Met à jour dans la base de donnée la course
        /// </summary>
        /// <param name="course">la course à mettre à jour</param>
        public void Update(Course course);

        /// <summary>
        /// Efface la course de la base de donnée
        /// </summary>
        /// <param name="course">la course à effacer</param>
        public void Delete(Course course);

        /// <summary>
        /// Retourne la liste de toutes les courses qui existe dans la BDD
        /// </summary>
        /// <returns>la liste de toutes les courses qui existe dans la BDD</returns>
        public IEnumerable<Course> ListAll();

    }
}
