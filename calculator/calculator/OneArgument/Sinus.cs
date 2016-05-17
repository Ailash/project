using System;

namespace calculator.OneArgument
{
    public class Sinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
         
    }
}