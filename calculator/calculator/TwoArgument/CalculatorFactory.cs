using System;

namespace calculator.TwoArgument
{
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new Add();
                   
                case "-":
                    return new Subtraction();
                    
                case "*":
                    return new Generation();
                    
                case "/":
                    return new Division();
                    
                default:
                    throw new Exception("неизвестная ошибка");
            }
        }
    }
}