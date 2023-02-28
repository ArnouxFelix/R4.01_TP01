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
        private string code;
        private string name;
        private int weight;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }

        public void Update()
        {

        }

        public Course(ICourseDAO dao)
        {
            courseDAO = dao;
        }
    }
}
