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
        /// UC_2
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
        /// <summary>
        /// UC_3
        /// Find's maximum the string.
        /// </summary>
        /// <param name="firstString">The first string.</param>
        /// <param name="secondString">The second string.</param>
        /// <param name="thirdString">The third string.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">the strings  are same.</exception>
        public string MaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
            {
                return thirdString;
            }
            throw new Exception("All the strings  are same.");
        }
    }
}
