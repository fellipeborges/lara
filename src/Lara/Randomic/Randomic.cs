using System;
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
        /// Instantiate a new Random object with the given seed (from SedSeed method) or with a random seed.
        /// </summary>
        private static readonly Func<Random> GetRandom = delegate ()
        {
            int seed = _seed == null ? Guid.NewGuid().GetHashCode() : (int)_seed;
            return new Random(seed);
        };
    }
}
