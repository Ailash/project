using calculator.TwoArgument;
using NUnit.Framework;

namespace calculatorTest
{
    [TestFixture]
    public class GenerationTest
    {
        [Test]
        public void SimpleGenerationTest()
        {
            ICalculator calc = new Generation();
            double result = calc.Calculate(5, 2);
            Assert.AreEqual(10, result);
        }   
    }
}