using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class PurityExamples
    {
        public int Sample1()
        {
            return 42;
        }

        public int Sample2(int a, int b)
        {
            return a + b;
        }

        public int Sample3(int a, int b)
        {
            int z = a + b;
            Console.WriteLine(z);
            return z;
        }
    }
}
