using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void SimpleDivisionTest()
        {
            ICalculator calc = new Division();
            double result = calc.Calculate(9, 3);
            Assert.AreEqual(3, result);
        }  
    }
}