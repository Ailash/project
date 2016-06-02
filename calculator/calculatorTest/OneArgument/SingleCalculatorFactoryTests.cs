using System;
using calculator.OneArgument;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.OneArgument
{
    public class SingleCalculatorFactoryTests
    {
        [TestCase("sin", typeof(Sinus))]
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("tan", typeof(Tangens))]
        public void CreateCalculatorTest(string name, Type type)
        {
            ISingleCalculator calc = SingleCalculatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calc);
        } 
    }
}