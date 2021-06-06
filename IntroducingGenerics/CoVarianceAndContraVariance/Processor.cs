using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVarianceAndContraVariance
{
    public class Processor<T> : IProcessor<T>
    {
        public void Process(T input)
        {
            Console.WriteLine($"Generic Processor of T, processing {input}");
        }
    }
}
