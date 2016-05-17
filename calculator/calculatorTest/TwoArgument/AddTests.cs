using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest.TwoArgument
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SimpleAddTest()
        {
            ICalculator calc = new Add();
            double result = calc.Calculate(2,3);
            Assert.AreEqual(5, result);
        } 
    }
}