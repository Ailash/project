using System;

namespace calculator.OneArgument
{
    public class Cosinus : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
         
    }
}