using System;

namespace calculator.OneArgument
{
    public class Exp : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
         
    }
}