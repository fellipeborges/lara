using System.Linq;

namespace Lara
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks if a value is contained in the given collection.
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="value">The value to be checked</param>
        /// <param name="collection">Collection to be checked on.</param>
        public static bool In<T>(this T value, params T[] collection)
        {
            return collection.Contains(value);
        }
    }
}
