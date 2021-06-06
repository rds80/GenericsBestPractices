using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class StudentPrinterService
    {
        private readonly IPersonRepository<Student> _studentRepository;

        public StudentPrinterService(IPersonRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void PrintStudents(int max = 100)
        {
            var students = _studentRepository.SortedList()
                                             .Take(max);

            PrintSmithsToConsole(students);
            var smiths = _studentRepository.Search("Smith");
            PrintSmithsToConsole(smiths);
        }

        private void PrintSmithsToConsole(IEnumerable<Student> students)
        {
            Console.WriteLine("Smiths:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
