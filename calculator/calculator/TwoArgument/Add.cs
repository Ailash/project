namespace calculator.TwoArgument
{
    public class Add: ICalculator
    {
        /// <summary>
        /// высчитываем сумму для двух аргументов
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }

       
    }
}