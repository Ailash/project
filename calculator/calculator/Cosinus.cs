using System;

namespace calculator
{
    public class Cosinus : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
         
    }
}