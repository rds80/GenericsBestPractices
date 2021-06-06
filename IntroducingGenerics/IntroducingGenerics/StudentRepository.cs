using System.Collections.Generic;
using System.Linq;

namespace IntroducingGenerics
{
    public record Name(string First, string Last);

    public class StudentRepository: IPersonRepository<Student>
    {
        private Name[] _names = new Name[10];

        public StudentRepository()
        {
            _names[0] = new("Steve", "Smith");
            _names[1] = new("Chad", "Smith");
            _names[2] = new("Ben", "Smith");
            _names[3] = new("Eric", "Smith");
            _names[4] = new("Julie", "Lerman");
            _names[5] = new("David", "Starr");
            _names[6] = new("Aaron", "Skonnard");
            _names[7] = new("Aaron", "Stewart");
            _names[8] = new("Aaron", "Powell");
            _names[9] = new("Aaron", "Frost");
        }

        public IEnumerable<Student> List()
        {
            int index = 0;
            while (index < _names.Length)
            {
                yield return new Student(_names[index].First, _names[index].Last);
                index++;
            }
        }

        public IEnumerable<Student> SortedList()
        {
            var students = List().ToList();
            students.Sort();
            return students;
        }

        public IEnumerable<Student> Search(string name)
        {
            return List().Where(student => student.LastName.Contains(name) ||
                student.FirstName.Contains(name));
        }

        public Student Create(Name name)
        {
            throw new System.NotImplementedException();
        }

        public Student CreateDefault()
        {
            throw new System.NotImplementedException();
        }
    }
}
