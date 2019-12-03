using System;
using System.Linq;

namespace Lara
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns a empty string if the object is null or the object.ToString() if not.
        /// </summary>
        /// <param name="value">The value to be checked</param>
        public static string EmptyIfNull(this object value)
        {
            return value == null ? "" : value.ToString();
        }
    }
}
