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

        [TestMethod]
        public void Subtract_WhenTheResultIsNegative_ShouldReturnZero()
        {
            //arrange
            Calculator calculator = new Calculator();
            //act
            int result = calculator.Subtract(10, 11);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Subtract_WhenTheResultIsNotNegative_ShouldReturnTheResult()
        {
            //arrange
            Calculator calculator = new Calculator();
            //act
            int result = calculator.Subtract(11, 10);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Multiply_WhenGivenTwoIntegers_ShouldReturnTheMultipliedValueDividedByThree()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(3, 3);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void Division_WhenGivenTwoIntegers_ShouldReturnTheFloorOfTheSquaredFirstNumberDividedByTheSecond()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(8, 2);
            Assert.AreEqual(32, result);

        }

        [TestMethod]
        public void ValidateInput_WhenGivenAValidIntString_ShouldReturnTrueAndTheInteger()
        {
            Calculator calculator = new Calculator();
            bool result = calculator.ValidateInput("1", out int resultValue);
            Assert.IsTrue(result);
            Assert.AreEqual(resultValue, 1);

        }

        [TestMethod]
        public void ValidateInput_WhenGivenAInvalidIntString_ShouldReturnFalseAndNull()
        {
            Calculator calculator = new Calculator();
            bool result = calculator.ValidateInput("apple", out int resultValue);
            Assert.IsFalse(result);
            Assert.AreEqual(resultValue, 0);

        }
    }
}
