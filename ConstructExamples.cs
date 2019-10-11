using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public static class ConstructExamples
    {
        public static long Triple(int value)
        {
            return value * 3;
        }

        public delegate long Multiplier(int value);

        static Multiplier tripler = Triple;

        public static void PrintMath(Func<int, long> calculator, int suppliedValue)
        {
            var result = calculator(suppliedValue);
            Console.WriteLine("The math operation on " + suppliedValue + " resulted in " + result);
        }

        public static void PrintMathTyped(Multiplier calculator, int suppliedValue)
        {
            var result = calculator(suppliedValue);
            Console.WriteLine("The math operation on " + suppliedValue + " resulted in " + result);
        }

        public static void Main(string[] args)
        {
            PrintMath(Triple, 4);
            PrintMath(x => x * 4, 4);

            PrintMathTyped(tripler, 5);  // Func and delegate are different types
        }
    }
}
