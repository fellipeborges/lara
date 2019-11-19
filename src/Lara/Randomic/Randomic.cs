using System;
using System.Collections;
using System.Collections.Generic;
using Lara.Randomizers;

namespace Lara
{
    public static class Randomic
    {
        private static int? _seed = null;

        /// <summary>
        /// Forces the Seed to a specific value. Usually used in Unit Testing when it's necessary to know which randomic value will be returned./// </summary>
        /// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence.</param>
        public static void SetSeed(int seed) => _seed = seed;

        /// <summary>
        /// Resets the Seed. Will force the library to create a different seed on every execution.
        /// </summary>
        public static void ResetSeed() => _seed = null;

        /// <summary>
        /// Offers Randomizers for basic types such as Int, Date, String, Bool, etc.
        /// </summary>
        public static IRandomBasic Basic => new RandomBasic(GetRandom);

        /// <summary>
        /// Returns a random value among the values of the informed array.
        /// </summary>
        /// <typeparam name="TReturn">Type of the return.</typeparam>
        /// <param name="options">Array of options to be considered on return.</param>
        public static TReturn Among<TReturn>(params TReturn[] options)
        {
            return new RandomAmong(Basic.Int).Among(options);
        }

        /// <summary>
        /// Returns a random value among the values of the informed collection.
        /// </summary>
        /// <typeparam name="TReturn">Type of the return.</typeparam>
        /// <param name="collection">IEnumerable of items to be considered on return.</param>
        public static TReturn Among<TReturn>(IEnumerable<TReturn> collection)
        {
            return new RandomAmong(Basic.Int).Among(collection);
        }

        /// <summary>
        /// Instantiate a new Random object with the given seed (from SedSeed method) or with a random seed.
        /// </summary>
        private static readonly Func<Random> GetRandom = delegate ()
        {
            int seed = _seed == null ? Guid.NewGuid().GetHashCode() : (int)_seed;
            return new Random(seed);
        };
    }
}
