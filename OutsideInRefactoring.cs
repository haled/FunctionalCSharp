using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class OutsideInRefactoring
    {
        public decimal CalcPayment(int amount, int length)
        {
            decimal payment = 0.0m;

            if (length != 0)
            {
                var rawPayment = (decimal)amount / length;
                payment = rawPayment + (rawPayment * 0.03m);
            }

            return payment;
        }

        public bool IsZero(int value)
        {
            return value == 0;
        }

        public decimal CalcPaymentRefactored(int amount, int length)
        {
            decimal payment = 0.0m;

            var rawPayment = IsZero(length) ? 0.0m : (decimal)amount / length;
            payment = rawPayment + (rawPayment * 0.03m);

            return payment;
        }
    }
}
