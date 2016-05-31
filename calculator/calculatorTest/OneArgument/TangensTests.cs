using calculator.OneArgument;
using NUnit.Framework;

namespace calculatorTest.OneArgument
{
     [TestFixture]
    public class TangensTests
    {
        [TestCase(1, 1.5574)]
        [TestCase(0.5, 0.5463)]
        [TestCase(0.1, 0.1003)]
        public void SimpleSinusTest(double first, double expected)
        {
            ISingleCalculator calc = new Tangens();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }   
    }
}