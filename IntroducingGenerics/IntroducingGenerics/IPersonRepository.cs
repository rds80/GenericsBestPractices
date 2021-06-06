using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public interface IPersonRepository<T>: IRepository<T> where T: Person, IComparable<T>, new()
    {
        IEnumerable<T> Search(string name);
        T Create(Name name);
        T CreateDefault();
    }

    public interface IPersonRepository
    {
        IEnumerable<T> Search<T>(string name) where T : Person;
        T Create<T>(Name name) where T : Person;
        T CreateDefault<T>() where T : Person, new();
    }
}
