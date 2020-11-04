
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
            ///Creates reference object.
            MaximumNumberCheck maximumNumber = new MaximumNumberCheck();
            Console.WriteLine("Welcome to Maximum Number Project.");
            ///Reads 3 integer values from user.
            Console.WriteLine("Enter three integers to find max of them.");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            ///Passes Values as parameter to method and stores max value in variable..
            int maxIntNumber = maximumNumber.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum integer value is:" + maxIntNumber);

            ///Reads 3 double values from user.
            Console.WriteLine("Enter three float numbers.");
            double firstDoubleValue = Convert.ToDouble(Console.ReadLine());
            double secondDoubleValue = Convert.ToDouble(Console.ReadLine());
            double thirdDoubleValue = Convert.ToDouble(Console.ReadLine());
            ///Passes Values as parameter to method and stores max value in variable.
            double maxDoubleNumber = maximumNumber.MaximumDoubleNumber(firstDoubleValue, secondDoubleValue, thirdDoubleValue);
            Console.WriteLine("Maximum double value is: " + maxDoubleNumber);
        }
    }
}
