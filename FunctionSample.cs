using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public static class FunctionSample
    {
        public static decimal Divide(int divisor, int dividend)
        {
            return divisor / dividend;  // assuming dividend != 0
        }

        public static decimal AttemptDivision(Func<int, int, decimal> workload, int divisor, int dividend)
        {
            try
            {
                return workload(divisor, dividend);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            var x = Divide(1, 0);  // throws an error

            var y = AttemptDivision(Divide, 1, 0);  // safer operation
        }

        public static int AddTwo(int x)
        {
            return x + 2;
        }

        public delegate int AddTwoFunction(int val);

        static AddTwoFunction adder = AddTwo;

        // Lambdas
        public static void ExpressionLambda()
        {
            int[] nums = {0, 1, 2, 3, 4, 5};
            var doubles = nums.Select(x = x * 2);
        }
    }
}
