using System;

namespace IntroducingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentPrinterService(new StudentRepository());
            studentService.PrintStudents(5);

            //var authorService = new AuthorPrinterService(new AuthorRepository());
            //authorService.PrintAuthors();
        }
    }
}
