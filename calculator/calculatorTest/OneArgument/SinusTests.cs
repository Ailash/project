using calculator.OneArgument;
using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.OneArgument
{
     [TestFixture]
    public class SinusTests
    {
        [TestCase(1, 0.8414)]
        [TestCase(0.5, 0.4794)]
        [TestCase(0.66, 0.6131)]
        public void SimpleSinusTest(double first, double expected)
        {
            ISingleCalculator calc = new Sinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }  
    }
}