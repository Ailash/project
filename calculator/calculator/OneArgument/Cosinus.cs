using System;

namespace calculator.OneArgument
{
   
    public class Cosinus : ISingleCalculator
    {
        /// <summary>
        /// вычисляет косинус числа
        /// </summary>
        /// <param name="first"></param>
        /// выводит значение аргумента
        /// <returns> возвращает значение аргумента
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
         
    }
}