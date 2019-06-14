using System;

namespace FunctionalCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int value = 0;
            Int32.TryParse(args[0], out value);

            decimal result = 0.0m;
            var message = "Pending";
            try
            {
                result = (decimal) 1 / value;
                message = "Success";
            }
            catch (System.Exception e)
            {
                message = "Failure due to: " + e.Message;
            }

            Console.WriteLine("The result is {0} with a message of {1}", result, message);
        }
    }
}
