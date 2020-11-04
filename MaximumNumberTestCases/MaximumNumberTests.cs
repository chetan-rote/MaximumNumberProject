using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberProject;

namespace FindMaximumNumberTest
{
    [TestClass]
    public class MaximumNumberTestCases
    {
        /// <summary>
        /// TC_1.1
        /// Givens the maximum number at first position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtFirstPosition_ShouldReturn_SameNumber()
        {
            ///Arrange
            int expectedValue = 11;
            MaximumNumberCheck maximumNumber = new MaximumNumberCheck();
            ///Act
            int actualValue = maximumNumber.MaximumIntegerNumber(11, 9, 5);
            ///Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// TC_1.2
        /// Givens the maximum number at second postion should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtSecondPostion_ShouldReturn_SameNumber()
        {
            ///Arrange
            int expectedValue = 11;
            MaximumNumberCheck maximumNumber = new MaximumNumberCheck();
            ///Act
            int actualValue = maximumNumber.MaximumIntegerNumber(9, 11, 5);
            ///Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        /// <summary>
        /// TC_1.3
        /// Givens the maximum number at third position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtThirdPosition_ShouldReturn_SameNumber()
        {
            ///Arrange
            int expectedValue = 11;
            MaximumNumberCheck maximumNumber = new MaximumNumberCheck();
            ///Act
            int actualValue = maximumNumber.MaximumIntegerNumber(5, 9, 11);
            ///Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
