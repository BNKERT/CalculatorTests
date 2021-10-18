using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTestingProject;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_WhenGivenTwoNumbers_ShouldReturnTheSum()
        {
            //arrange
            Calculator calculator = new Calculator();
            //act
            int result = calculator.Add(5, 10);

            Assert.AreEqual(15, result);
        }
    }
}
