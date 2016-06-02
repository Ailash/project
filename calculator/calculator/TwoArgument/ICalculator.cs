namespace calculator.TwoArgument
{
    
    public interface ICalculator
    {
        /// <summary>
        /// высчитываем значения для двух аргументов
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        double Calculate(double first, double second);
    }
}
