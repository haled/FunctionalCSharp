using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class LambdaExample
    {
        public static decimal CalcCircleArea(Func<int,long> rSquared, int radius)
        {
            decimal pi = 3.14159m;

            return pi * rSquared(radius);
        }

public static void RecordMessage(Func<string> generator, string message)
{
    Console.WriteLine(generator + message);
}

        public static void Main(string[] args)
        {
            Func<int, long> Square = x => x * x;
            var area = CalcCircleArea(Square, 5);

            var otherArea = CalcCircleArea(x => (long) x * x, 7);

            RecordMessage(() => "Parse string.".Substring(2, 4), " do you see the parsing?");

        }


    }
}
