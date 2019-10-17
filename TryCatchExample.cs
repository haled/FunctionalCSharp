using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public static class TryCatchExample
    {
        public static IResult TryCatch(Func<decimal> workload)
        {
            try
            {
                var result = new SuccessResult();
                result.ResultValue = workload();
                result.Message = "Success";
                return result;
            }
            catch (System.Exception e)
            {
                var result = new FailedResult();
                result.ResultValue = 0.0m;
                result.Message = "Failure due to: " + e.Message;
                return result;
            }
        }

        public static void TestTryCatch()
        {
            var someValue = 0.0m;
            var result = TryCatch(() => 1 / someValue);
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
