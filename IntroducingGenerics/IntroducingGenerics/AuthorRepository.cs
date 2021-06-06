using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class AuthorRepository : IRepository<Author>
    {
        public IEnumerable<Author> List()
        {
            var authors = new Author[10];
            authors[0] = new Author("Steve", "Smith");
            authors[1] = new Author("Chad", "Smith");
            authors[2] = new Author("Ben", "Smith");
            authors[3] = new Author("Eric", "Smith");
            authors[4] = new Author("Julie", "Lerman");
            authors[5] = new Author("David", "Starr");
            authors[6] = new Author("Aaron", "Skonnard");
            authors[7] = new Author("Aaron", "Stewart");
            authors[8] = new Author("Aaron", "Powell");
            authors[9] = new Author("Aaron", "Frost");

            return authors;
        }
    }
}
