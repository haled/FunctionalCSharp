using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class NormalRefactoring
    {
        public decimal Divide(int divisor, int dividend)
        {
            decimal quotient = 0.0m;

            if(dividend != 0)
            {
                quotient = (decimal) divisor / dividend;
            }

            return quotient;
        }

        public decimal DoDivision(int x, int y)
        {
            return (decimal) x / y;
        }

        public decimal RefactoredDivide(int divisor, int dividend)
        {
            decimal quotient = 0.0m;

            if (dividend != 0)
            {
                quotient = DoDivision(divisor, dividend);
            }

            return quotient;
        }
    }
}
