using System;

namespace FunctionalCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int value = 0;
            Int32.TryParse(args[0], out value);
            
            Console.WriteLine("Initial implementation.");
            Console.WriteLine(BadValueCalculator.Calculate(value));

            Console.WriteLine("\n\n");

            // object returned
            Console.WriteLine("Attempt with an output object.");
            var r = BadValueCalculator.CalculateResult(value);
            Console.WriteLine("The result is {0} with a message of {1}", r.ResultValue, r.Message);

            Console.WriteLine("\n\n");

            // functional try-catch
            Console.WriteLine("Attempt with functional Try/Catch.");
            var q = ExceptionHandler.TryCatch(() => (decimal) 1 / value);
            Console.WriteLine("The result is {0} with a message of {1}", q.ResultValue, q.Message);

            Console.WriteLine("Attempt with truly functional Try/Catch.");
            var s = ExceptionHandler.TryCatch(() => BadValueCalculator.CalculateFreely(value));
            Console.WriteLine("The result is {0} with a message of {1}", s.ResultValue, s.Message);
        }
    }
}
