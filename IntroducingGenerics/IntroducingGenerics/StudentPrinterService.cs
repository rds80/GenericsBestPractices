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
            var students = _studentRepository.List()
                                             .Take(max);

            //Array.Sort(students);

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
