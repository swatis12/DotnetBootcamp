using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new CalculatorLib.Calculator();
            Assert.AreEqual(30, calculator.Add(10, 20));
        }
    }
}
