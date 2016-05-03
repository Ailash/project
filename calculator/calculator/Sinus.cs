using System;

namespace calculator
{
    public class Sinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
         
    }
}