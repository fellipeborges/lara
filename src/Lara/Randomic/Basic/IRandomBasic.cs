using System;

namespace Lara.Randomizers
{
    public interface IRandomBasic
    {
        /// <summary>
        /// Returns a random new Guid.
        /// Example: 9ed48db8-bcef-4414-a245-60ea8df97fa6
        /// </summary>
        Guid Guid();

        /// <summary>
        /// Generates a random Integer between the min and max values.
        /// Examples: 1, 42, 698855654412
        /// </summary>
        /// <param name="minValue">The minimum desired value.</param>
        /// <param name="maxValue">The maximum desired value.</param>
        int Int(int minValue = 0, int maxValue = int.MaxValue);

        /// <summary>
        /// Generates a random Double between the min and max values.
        /// Examples: 1.42, 4.470298065951377E+307
        /// </summary>
        /// <param name="minValue">The minimum desired value.</param>
        /// <param name="maxValue">The maximum desired value.</param>
        double Double(double minValue = 0, double maxValue = double.MaxValue);

        /// <summary>
        /// Generates a random Byte between 0 and 255.
        /// Examples: 0, 42
        /// </summary>
        byte Byte();

        /// <summary>
        /// Generates a random 16 letter string.
        /// Example: "MFYoiWSxFhBMQzji" 
        /// </summary>
        string Text();

        /// <summary>
        /// Generates a random string with the given length.
        /// Example: "MFYoiWSxFhBMQzjiOfkkxEITpIpPqucl"
        /// </summary>
        string Text(int length);

        /// <summary>
        /// Generates a random 16 letter Alphanumeric string.
        /// Example: "PGcvoaV7GnBPT0qo" 
        /// </summary>
        string Alphanumeric();

        /// <summary>
        /// Generates a random Alphanumeric string with the given length.
        /// Example: "PGcvoaV7GnBPT0qoRmrr7FJXxKxTz3is" 
        /// </summary>
        string Alphanumeric(int length);

        /// <summary>
        /// Generates a random 16 digit numeric string.
        /// Example: "6541236985479856"
        /// </summary>
        string Numeric();

        /// <summary>
        /// Generates a random numeric string with the given length.
        /// Example: "093285"
        /// </summary>
        string Numeric(int length);

        /// <summary>
        /// Generates a random Date between the min and max dates.
        /// Examples: 2018-09-04, 1990-08-27
        /// </summary>
        /// <param name="minDate">The minimum desired date. If not informed it will be 1970-01-01.</param>
        /// <param name="maxDate">The maximum desired date. If not informed it will be 2099-12-31.</param>
        DateTime Date(DateTime? minDate = null, DateTime? maxDate = null);

        /// <summary>
        /// Generates a random DateTime between the min and max dates.
        /// Example: 1984-01-23 16:41:55 
        /// </summary>
        /// <param name="minDateTime">The minimum desired date/time. If not informed it will be 1970-01-01 00:00:00.</param>
        /// <param name="maxDateTime">The maximum desired date/time. If not informed it will be 2099-12-31 23:59:59.</param>
        DateTime DateTime(DateTime? minDateTime = null, DateTime? maxDateTime = null);

        /// <summary>
        /// Generates a random Boolean value (true or false)
        /// Examples: true, false
        /// </summary>
        bool Boolean();

        /// <summary>
        /// Generates a random Boolean value (true or false) with a probability of true.
        /// Examples: true, false
        /// </summary>
        /// <param name="probabilityOfTrue">The probability of generating the true value.
        /// Must be a value from 0.0 (always false) to 1.0 (always true) with increments of 10% (0.1, 0.2, 0.3, etc)</param>
        bool Boolean(double probabilityOfTrue);

        /// <summary>
        /// Returns the even or the odd value based on the counter.
        /// Usefull for iterators (for i...) when it's necessary to return one or the other value.
        /// Examples: "#fff", "#ccc"
        /// </summary>
        /// <typeparam name="TReturn">Type of the return.</typeparam>
        /// <param name="counter">Iterator used to decide if it will be returned the Even or the Odd value.</param>
        /// <param name="evenValue">Value to be returned when the counter is even.</param>
        /// <param name="oddValue">Value to be returned when the counter is odd.</param>
        TReturn EvenOdd<TReturn>(int counter, TReturn evenValue, TReturn oddValue);
    }
}
