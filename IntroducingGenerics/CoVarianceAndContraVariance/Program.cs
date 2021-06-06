using System;

namespace CoVarianceAndContraVariance
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionSamples.Execute();
        }
    }

    public record Customer(string firstName, string lastName);
}
