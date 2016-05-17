using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest
{
    [TestFixture]
    public class SubtractionTest
    {
        [Test]
        public void SimpleSubtractionTest()
        {
            ICalculator calc = new Subtraction();
            double result = calc.Calculate(5, 3);
            Assert.AreEqual(2, result);
        } 
         
    }
}