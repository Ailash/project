using System;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.TwoArgument
{
    public class CalculatorFactoryTests
    {
        [TestCase("+", typeof(Add))]
        [TestCase("-", typeof(Subtraction))]
        [TestCase("*", typeof(Generation))]
        [TestCase("/", typeof(Division))]
        public void CreateCalculatorTest(string name, Type type)
        {
            ICalculator calc = CalculatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calc);
        }  
    }
}