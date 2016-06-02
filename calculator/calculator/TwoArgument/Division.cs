using System;

namespace calculator.TwoArgument
{
    public class Division: ICalculator
    {
        /// <summary>
        /// делим два аргумента
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
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