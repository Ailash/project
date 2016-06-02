using System;

namespace calculator.OneArgument
{
    
    public static class SingleCalculatorFactory
    {
        /// <summary>
        /// вычисляет синус, косинус, логарифм, тангенс
        /// </summary>
        /// <param name="name"></param>
        /// выводит значения
        /// <returns></returns>
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sin":
                    return new Sinus();
                case "cos":
                    return new Cosinus();
                case "log":
                    return new Logarifm();
                case "tan":
                    return new Tangens();
                case "exp":
                    return new Exp();
                default:
                    throw new Exception("неизвестная ошибка");
            }
        } 
    }
}