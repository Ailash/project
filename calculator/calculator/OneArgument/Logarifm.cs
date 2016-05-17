using System;

namespace calculator.OneArgument
{
    public class Logarifm : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
         
    }
}