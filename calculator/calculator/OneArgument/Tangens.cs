using System;

namespace calculator.OneArgument
{
    public class Tangens : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
         
    }
}