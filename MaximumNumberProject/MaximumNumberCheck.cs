using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberProject
{
    public class MaximumNumberCheck<T> where T : IComparable 
    {
        /// <summary>
        /// Generic T value
        /// </summary>
        public T[] value;
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumNumberCheck{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public MaximumNumberCheck(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// Sorts the specified values in array.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// Finds maximum value from arrray.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        /// <summary>
        /// Stores the max value on max variable and returns it.
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        /// <summary>
        /// Prints the maximum value.
        /// </summary>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is:" + max);
        }
    }
}
