using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ICourseDAO
    {
        public void Create(Course course);
        public Course Read(string code);

        public void Update(Course course);

        public void Delete(Course course);

        public Course[] ListAll();

    }
}
