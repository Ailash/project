using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.TwoArgument
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(10, 24, 34)]
        [TestCase(12.3, 22, 34.3)]
        public void SimpleAddTest(double first, double second, double expected)
        {
            ICalculator calc = new Add();
            double result = calc.Calculate(first,second);
            Assert.AreEqual(expected, result);
        } 
    }
}