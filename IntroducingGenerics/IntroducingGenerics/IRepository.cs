using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public interface IRepository<T> where T: IComparable<T>
    {
        IEnumerable<T> List();
    }
}
