using System;

namespace Lara
{
    public static class ThrowExtensions
    {
        /// <summary>
        /// Throws an Exception of type "ArgumentNullException" in case the value is null, empty, white space.
        /// </summary>
        /// <param name="obj">Object to be evaluated.</param>
        /// <param name="argumentName">Argument name to be shown in the Exception Message.</param>
        public static void ThrowIfNoValue(this object obj, string argumentName)
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj.ToString()))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Throws an Exception of the informed type in case the value is null, empty or white space.
        /// </summary>
        /// <typeparam name="TException">The type of the Exception to be thrown.</typeparam>
        /// <param name="obj">Object to be evaluated.</param>
        /// <param name="message">The Exception Message.</param>
        public static void ThrowIfNoValue<TException>(this object obj, string message) where TException : Exception, new()
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj.ToString()))
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message);
            }
        }

        /// <summary>
        /// Throws an Exception of type "ArgumentNullException" in case the value is null or zero.
        /// </summary>
        /// <param name="obj">Object to be evaluated.</param>
        /// <param name="argumentName">Argument name to be shown in the Exception Message.</param>
        public static void ThrowIfZero(this object obj, string argumentName)
        {
            if (IsNullOrZero(obj))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Throws an Exception of the informed type in case the value is null or zero.
        /// </summary>
        /// <typeparam name="TException">The type of the Exception to be thrown.</typeparam>
        /// <param name="obj">Object to be evaluated.</param>
        /// <param name="message">The Exception Message.</param>
        public static void ThrowIfZero<TException>(this object obj, string message) where TException : Exception, new()
        {
            if (IsNullOrZero(obj))
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message);
            }
        }

        /// <summary>
        /// Checks if a value is null or zero by trying to convert it to Int, Long and Double.
        /// </summary>
        /// <param name="obj">The value to be checked.</param>
        private static bool IsNullOrZero(object obj)
        {
            if (obj == null) return true;
            if (string.IsNullOrWhiteSpace(obj.ToString())) return true;
            if (int.TryParse(obj.ToString(), out int intValue))
            {
                if (intValue == 0) return true;
            }
            if (long.TryParse(obj.ToString(), out long longValue))
            {
                if (longValue == 0) return true;
            }
            if (double.TryParse(obj.ToString(), out double doubleValue))
            {
                if (doubleValue == 0) return true;
            }

            return false;
        }
    }
}
