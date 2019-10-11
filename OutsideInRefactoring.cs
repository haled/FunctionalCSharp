using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class OutsideInRefactoring
    {
        public decimal Divide(int divisor, int dividend)
        {
            decimal quotient = 0.0m;

            if (dividend != 0)
            {
                quotient = (decimal)divisor / dividend;
            }

            return quotient;
        }

        public bool IsZero(int value)
        {
            return value == 0;
        }

        public decimal RefactoredDivide(int divisor, int dividend)
        {
            return IsZero(dividend) ? 0.0m : divisor / dividend;
        }
    }
}
