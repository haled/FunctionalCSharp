using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalCSharp
{
    public class FunctionComposition
    {
        public static Func<dynamic> Timer(Func<dynamic> workload)
        {
            return () =>
            {
                Console.WriteLine("Start time: " + DateTime.Now);
                var result = workload();
                Console.WriteLine("End time: " + DateTime.Now);
                return result;
            };
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static void OtherMain(string[] args)
        {
            Func<dynamic> Multiplier = Timer(() => Multiply(4, 5));
            Console.WriteLine("Timed result is " + Multiplier());
        }

        public static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            Func<dynamic> listMultiplication = () =>
            {
                return nums.Aggregate((x, y) => Multiply(x, y));
            };
            Func<dynamic> TimedMultiplication = Timer(listMultiplication);
            var result = TimedMultiplication();
            Console.WriteLine("The result is -> " + result);
            Console.ReadLine();
        }

        public static long MultiplierWithTiming(int a, int b)
        {
            Console.WriteLine("Starting at " + DateTime.Now);

            var result = a * b;

            Console.WriteLine("Ending at " + DateTime.Now);

            return result;
        }
        
        public static long AddWithTiming(int a, int b)
        {
            Console.WriteLine("Starting at " + DateTime.Now);

            var result = a + b;

            Console.WriteLine("Ending at " + DateTime.Now);

            return result;
        }
    }
}
