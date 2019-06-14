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
            InitialImplementation(value);

            Console.WriteLine("\n\n");

            // object returned
            Console.WriteLine("Attempt with an output object.");
            var r = AttemptWithOutputObject(value);
            Console.WriteLine("The result is {0} with a message of {1}", r.ResultValue, r.Message);
        }

        public static void InitialImplementation(int value)
        {
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

        public static IResult AttemptWithOutputObject(int value)
        {
            try
            {
                var result = new SuccessResult();
                result.ResultValue = (decimal) 1 / value;
                result.Message = "Success";
                return result;
            }
            catch (System.Exception e)
            {
                var result = new FailedResult();
                result.Message = "Failure due to: " + e.Message;
                return result;
            }

            
        }
    }

    public interface IResult
    {
        decimal ResultValue { get; set; }
        string Message { get; set; }
    }

    public class SuccessResult : IResult
    {
        public decimal ResultValue { get; set; }
        public string Message { get; set; }
    }

    public class FailedResult : IResult
    {
        public decimal ResultValue { get; set; }
        public string Message { get; set; }
    }
}
