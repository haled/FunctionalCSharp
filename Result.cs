namespace FunctionalCSharp
{
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