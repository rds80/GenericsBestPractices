using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class AuthorPrinterService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorPrinterService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void PrintAuthors()
        {
            var authors = _authorRepository.List().ToArray();

            Array.Sort(authors);

            Console.WriteLine("");
            Console.WriteLine("Authors:");
            for (int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine(authors[i]);
            }
        }
    }
}
