using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Lara
{
    public static class TextExtensions
    {
        /// <summary>
        /// Slices the string and returns only the informed length from Left to Right.
        /// </summary>
        /// <param name="value">String to be sliced</param>
        /// <param name="length">Number of characters</param>
        public static string Left(this string value, int length)
        {
            if (string.IsNullOrWhiteSpace(value) || length == 0)
                return "";

            length = Math.Abs(length);
            return (value.Length <= length
                   ? value
                   : value.Substring(0, length)
                   );
        }

        /// <summary>
        /// Slices the string and returns only the informed length from Right to Left.
        /// </summary>
        /// <param name="value">String to be sliced</param>
        /// <param name="length">Number of characters</param>
        public static string Right(this string value, int length)
        {
            if (string.IsNullOrWhiteSpace(value) || length == 0)
                return "";

            length = Math.Abs(length);
            return (value.Length <= length
                   ? value
                   : value.Substring(value.Length - length, length)
                   );
        }

        /// <summary>
        /// Removes all the accentuation from a string.
        /// Example: "Café" returns "Cafe".
        /// </summary>
        /// <param name="value">The value to have the accentuation removed.</param>
        public static string RemoveAccentuation(this string value)
        {
            var normalizedString = value.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
