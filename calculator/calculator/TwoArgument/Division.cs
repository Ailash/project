using System;

namespace calculator.TwoArgument
{
    public class Division: ICalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("деление на ноль");
            }
            return first / second;
        }
 
    }
}