using System;
using System.Globalization;

namespace Lara
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns the first day of a month from a given date.
        /// </summary>
        public static DateTime FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Returns the last day of a month from a given date.
        /// </summary>
        public static DateTime LastDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        /// <summary>
        /// Formats the Date/Time in the informed pre-defined format.
        /// </summary>
        public static string ToFormat(this DateTime value, PreDefinedFormat preDefinedFormat)
        {
            string format = preDefinedFormat switch
            {
                PreDefinedFormat.Brazilian => "dd/MM/yyyy",
                PreDefinedFormat.BrazilianWithTime => "dd/MM/yyyy HH:mm:ss",
                PreDefinedFormat.American => "MM/dd/yyyy",
                PreDefinedFormat.AmericanWithTime => "MM/dd/yyyy hh:mm:ss tt",
                PreDefinedFormat.YearMonthDay => "yyyy-MM-dd",
                PreDefinedFormat.YearMonthDayWithTime => "yyyy-MM-dd HH:mm:ss",
                PreDefinedFormat.MonthYear => "MM/yyyy",
                _ => "yyyy-MM-dd HH:mm:ss"
            };
            
            return value.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
