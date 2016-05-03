using System;

namespace calculator
{
    public class Tangens : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
         
    }
}