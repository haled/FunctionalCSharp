using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class ImpureExamples
    {
        public int CurrentSeconds()
        {
            return DateTime.Now.Second;
        }

        public string GetGreeting(string name)
        {
            return "Hello " + name + " the current time is " + DateTime.Now;
        }

        public class Sum
        {
            private int _value = 0;

            public int SumValue { get; set; }

            public Sum(int val)
            {
                _value = val;
            }
        }
        public Sum GetSum(int a, int b)
        {
            if(a < 0 || b < 0)
            {
                return null;
            }
            else
            {
                return new Sum(a + b);
            }
        }

        public int GetSum2(int a, int b)
        {
            if(a < 0 || b < 0)
            {
                throw new Exception("I don't do negatives.");
            }
            else
            {
                return a + b;
            }
        }
    }
}
