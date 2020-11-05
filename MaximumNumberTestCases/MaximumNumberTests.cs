using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberProject;

namespace FindMaximumNumberTest
{
    [TestClass]
    public class MaximumNumberTestCases
    {
        /// <summary>
        /// Givens the integer array should return largest integer.
        /// </summary>
        [TestMethod]
        public void GivenIntegerArray_Should_Return_LargestInteger()
        {
            ///Arrange
            int[] values = { 3, 6, 7, 10, 4, 8 };
            MaximumNumberCheck<int> maximumNumber = new MaximumNumberCheck<int>(values);
            ///Act
            int max = maximumNumber.MaxMethod();
            ///Assert
            Assert.AreEqual(10, max);
        }
        /// <summary>
        /// Givens the double array should return largest double.
        /// </summary>
        [TestMethod]
        public void GivenDoubleArray_Should_Return_LargestDouble()
        {
            ///Arrange
            double[] values = { 10.6, 25.9, 8.2, 9.56};
            MaximumNumberCheck<double> maximumNumber = new MaximumNumberCheck<double>(values);
            ///Act
            double max = maximumNumber.MaxMethod();
            ///Assert
            Assert.AreEqual(25.9, max);
        }
        /// <summary>
        /// Givens the string array should return largest string.
        /// </summary>
        [TestMethod]
        public void GivenStringArray_Should_Return_LargestString()
        {
            ///Arrange
            string[] values = { "22", "98", "99", "33"};
            MaximumNumberCheck<string> maximumNumber = new MaximumNumberCheck<string>(values);
            ///Act
            string max = maximumNumber.MaxMethod();
            ///Assert
            Assert.AreEqual("99", max);
        }
    }
}
