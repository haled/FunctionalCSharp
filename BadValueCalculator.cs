namespace FunctionalCSharp
{
    public static class BadValueCalculator
    {
        public static string Calculate(int value)
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

            return "The result is " + result + " with a message of " + message;
        }

        public static IResult CalculateResult(int value)
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
                result.ResultValue = 0.0m;
                result.Message = "Failure due to: " + e.Message;
                return result;
            }
        }

        public static IResult CalculateFreely(int val)
        {
            var result = new SuccessResult();
            result.ResultValue = (decimal) 1 / val;
            result.Message = "Success";
            return result;
        }
    }
}