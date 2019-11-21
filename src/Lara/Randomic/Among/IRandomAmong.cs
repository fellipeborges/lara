using System;
using System.Collections.Generic;

namespace Lara.Randomizers
{
    public interface IRandomAmong
    {
        /// <summary>
        /// Returns a random value among the values of the informed array.
        /// </summary>
        /// <param name="options">Array of options to be considered on return.</param>
        string Strings(params string[] options);

        /// <summary>
        /// Returns a random value among the values of the informed collection.
        /// </summary>
        /// <param name="collection">IEnumerable of items to be considered on return.</param>
        string Strings(IEnumerable<string> collection);

        /// <summary>
        /// Returns a random value among the values of the informed array.
        /// </summary>
        /// <param name="options">Array of options to be considered on return.</param>
        int Ints(params int[] options);

        /// <summary>
        /// Returns a random value among the values of the informed collection.
        /// </summary>
        /// <param name="collection">IEnumerable of items to be considered on return.</param>
        int Ints(IEnumerable<int> collection);

        /// <summary>
        /// Returns a random value among the values of the informed array.
        /// </summary>
        /// <typeparam name="TReturn">Type of the return.</typeparam>
        /// <param name="options">Array of options to be considered on return.</param>
        TReturn Other<TReturn>(params TReturn[] options);

        /// <summary>
        /// Returns a random value among the values of the informed collection.
        /// </summary>
        /// <typeparam name="TReturn">Type of the return.</typeparam>
        /// <param name="collection">IEnumerable of items to be considered on return.</param>
        TReturn Other<TReturn>(IEnumerable<TReturn> collection);
    }
}
