using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class FunctionSampleTwo
    {
        private delegate decimal AreaCalculator(int val);  // Define function as data

        public decimal Square(int x)
        {
            return (decimal) x * x;
        }

        // Pass function as data
        // Functions passed as parameters to other functions
        public decimal CalcCircleAreaWithFunc(Func<decimal,int> calculator, int radius)
        {
            return 3.14159m * calculator(radius);
        }

        // Function as a return type
        public Func<decimal> CalcCircleAreaFunction(int radius)
        {
            return () => 3.14159m * Square(radius);
        }

        public decimal GetSpecialShapeArea(int dimension, ShapeType shape)
        {
            AreaCalculator calculate;

            if(shape == ShapeType.Circle)
            {
                calculate = CalcCircleAreaFunction(dimension);
            }
            else
            {
                calculate = Square;
            }

            return calculate(dimension);
        }

        public Action<string> PrintMessage;

        public static void MessagePrinter(string value)
        {
            Console.WriteLine(value);
        }

        PrintMessage = MessagePrinter;
    }

    public enum ShapeType
    {
        Circle,
        Square
    }
}
