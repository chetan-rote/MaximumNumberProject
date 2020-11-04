using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberProject
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// UC_1
        /// Find's maximum integer number.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">All the number have same value</exception>
        public int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            ///Checks whether firstValue is greater than other two, if it's greater will return firstValue.
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            ///Checks whether secondValue is greater than other two, if it's greater will return secondValue.
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            ///Checks whether thirdValue is greater than other two, if it's greater will return thirdValue.
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("All the number have same value");
        }
        /// <summary>
        /// Find's maximum double number.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">All the number have same value</exception>
        public double MaximumDoubleNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("All the number have same value");
        }
    }
}
