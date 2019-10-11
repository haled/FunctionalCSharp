using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalCSharp
{
    public class MathProblem
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ImmutabilityExample
    {
        // Mutation
public MathProblem Addition(MathProblem prob)
{
    var z = prob.X + prob.Y;
    prob.X = z;
    return prob;
}

// Immutable
public MathProblem Subtraction(MathProblem prob)
{
    MathProblem result = new MathProblem;
    result.X = prob.X + prob.Y;
    return result;
}
    }
}
