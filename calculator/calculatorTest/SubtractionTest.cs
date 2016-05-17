using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest
{
    [TestFixture]
    public class SubtractionTest
    {
        [TestCase(5, 3, 2)]
        [TestCase(123, 24, 99)]
        [TestCase(12.3, 22, -9.7)]
        public void SimpleSubtractionTest(double first, double second, double expected)
        {
            ICalculator calc = new Subtraction();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        } 
         
    }
}