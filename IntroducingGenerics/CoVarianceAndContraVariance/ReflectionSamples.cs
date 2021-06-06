using System;

namespace CoVarianceAndContraVariance
{
    public class ReflectionSamples
    {
        public static void Execute()
        {
            var openProcessorInterface = typeof(IProcessor<>);
            Console.WriteLine($"Is Processor<> Generic? {openProcessorInterface.IsGenericType}");
            Console.WriteLine($"Is Processor<> Generic? {openProcessorInterface.IsGenericTypeDefinition}");
        }
    }
}