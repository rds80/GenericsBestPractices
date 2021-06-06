using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class StudentPrinterService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentPrinterService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void PrintStudents(int max = 100)
        {
            var students = _studentRepository.List().ToArray();

            Array.Sort(students);

            for (int i = 0; i < students.Length && i < max; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
