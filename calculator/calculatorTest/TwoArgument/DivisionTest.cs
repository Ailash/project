using System;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.TwoArgument
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(33, 3, 11)]
        [TestCase(-56, 28, -2)]
        [TestCase(180.8, 4, 45.2)]
        public void SimpleDivisionTest(double first, double second, double expected)
        {
            ICalculator calc = new Division();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            ICalculator calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(89, 0));

        }  
    }
}