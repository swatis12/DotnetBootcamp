using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLib.MsTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_returns_summation_of_numbers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(10, 20);
            Assert.IsTrue(30 == result);
        }
    }
}
