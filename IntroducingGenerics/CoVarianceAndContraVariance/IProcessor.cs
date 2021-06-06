using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVarianceAndContraVariance
{
    public interface IProcessor<T>
    {
        void Process(T input);
    }
}
