using System;

namespace calculator
{
    public class Logarifm : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
         
    }
}