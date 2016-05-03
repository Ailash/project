using System;

namespace calculator
{
    public class SingleCalculatorFactory
    {
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