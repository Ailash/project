using calculator.OneArgument;
using NUnit.Framework;

namespace calculatorTest.OneArgument
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0.11, 0.9939)]
        [TestCase(0.5, 0.8775)]
        [TestCase(0.3, 0.9553)]
        public void SimpleSinusTest(double first, double expected)
        {
            ISingleCalculator calc = new Cosinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}