using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class StudentRepository: IRepository<Student>
    {
        public IEnumerable<Student> List()
        {
            var students = new Student[10];
            students[0] = new Student("Steve", "Smith");
            students[1] = new Student("Chad", "Smith");
            students[2] = new Student("Ben", "Smith");
            students[3] = new Student("Eric", "Smith");
            students[4] = new Student("Julie", "Lerman");
            students[5] = new Student("David", "Starr");
            students[6] = new Student("Aaron", "Skonnard");
            students[7] = new Student("Aaron", "Stewart");
            students[8] = new Student("Aaron", "Powell");
            students[9] = new Student("Aaron", "Frost");

            return students;
        }
    }
}
