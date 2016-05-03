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
                default:
                    throw new Exception("неизвестная ошибка");
            }
        } 
    }
}