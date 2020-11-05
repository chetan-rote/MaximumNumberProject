
/******************************************************************************  
 *  Purpose: Find maximum from given integer double numbers and string using .Net Generics.
 *
 *
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   04-10-2020
 *
 ******************************************************************************/
using System;

namespace MaximumNumberProject
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Integer array with values.
            int[] intArray = { 11, 55, 22, 33, 44 };
            ///Creates reference of the genreic class by passing int type.
            MaximumNumberCheck<int> maximumNumberCheck = new MaximumNumberCheck<int>(intArray);
            ///Prints max value using printMax Generic method.
            maximumNumberCheck.PrintMaxValue();

            ///Double array with values.
            double[] doubleArray = { 11.1, 22.5, 64.5, 33.4 };
            ///Creates reference of the genreic class by passing double type.
            MaximumNumberCheck<double> maximumNumberCheck1 = new MaximumNumberCheck<double>(doubleArray);
            ///Prints max value using printMax Generic method.
            maximumNumberCheck1.PrintMaxValue();

            ///String array with values.
            string[] stringArray = { "25", "35", "63", "12"};
            ///Creates reference of the genreic class by passing string type.
            MaximumNumberCheck<string> maximumNumberCheck2 = new MaximumNumberCheck<string>(stringArray);
            ///Prints max value using printMax Generic method.
            maximumNumberCheck2.PrintMaxValue();
        }
    }
}
