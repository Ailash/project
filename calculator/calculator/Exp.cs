using System;

namespace calculator
{
    public class Exp : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
         
    }
}