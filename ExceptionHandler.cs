using System;

namespace FunctionalCSharp
{
    public static class ExceptionHandler
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
        
        public static IResult TryCatch(int val, Func<decimal, int> workload)
        {
            try
            {
                var result = new SuccessResult();
                result.ResultValue = workload(val);
                result.ResultValue = 0.0m;
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

        public static IResult TryCatch(Func<IResult> workload)
        {
            try
            {
                return workload();
            }
            catch (System.Exception e)
            {
                var result = new FailedResult();
                result.ResultValue = 0.0m;
                result.Message = "Failure due to: " + e.Message;
                return result;
            }
        }
    }
}