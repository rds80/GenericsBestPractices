using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public interface IPersonRepository<T>: IRepository<T> where T: Person, IComparable<T>
    {
        IEnumerable<T> Search(string name);
    }
}
