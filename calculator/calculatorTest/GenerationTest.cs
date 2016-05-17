using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest
{
    [TestFixture]
    public class GenerationTest
    {
        [TestCase(33, 3, 99)]
        [TestCase(-56, 28, -1568)]
        [TestCase(5.46, 34, 185.64)]
        public void SimpleGenerationTest(double first, double second, double expected)
        {
            ICalculator calc = new Generation();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }   
    }
}