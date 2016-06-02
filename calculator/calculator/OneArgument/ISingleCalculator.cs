namespace calculator.OneArgument
{
    
    public interface ISingleCalculator
    {
        /// <summary>
        /// высчитывает значения для одного аргумента
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        double Calculate(double first);
    }
}