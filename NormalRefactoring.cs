using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class NormalRefactoring
    {
        public decimal CalcPayment(int amount, int length)
        {
            decimal payment = 0.0m;

            if(length != 0)
            {
                var rawPayment = (decimal) amount / length;
                payment = rawPayment + (rawPayment * 0.03m);
            }

            return payment;
        }

        public decimal DeterminePayment(int amt, int len)
        {
            var rawPayment = (decimal) amt / len;
            return (rawPayment + (rawPayment * 0.03m));
        }

        public decimal CalcPaymentRefactored(int amount, int length)
        {
            decimal payment = 0.0m;

            if (length != 0)
            {
                payment = DeterminePayment(amount, length);
            }

            return payment;
        }
    }
}
