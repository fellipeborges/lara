using Lara.Randomizers;
using System;

namespace Lara
{
    public static class Randomic
    {
        private static int? Seed = null;
        private static Language Language = Language.EnUs;

        /// <summary>
        /// Sets the language that will be used for some randomic generators (mainly People and Location).
        /// If none language is defined it will uses English as default.
        /// </summary>
        public static void SetLanguage(Language language) => Language = language;

        /// <summary>
        /// Forces the Seed to a specific value. Usually used in Unit Testing when it's necessary to know which randomic value will be returned./// </summary>
        /// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence.</param>
        public static void SetSeed(int seed) => Seed = seed;

        /// <summary>
        /// Resets the Seed. Will force the library to create a different seed on every execution.
        /// </summary>
        public static void ResetSeed() => Seed = null;

        /// <summary>
        /// Offers Randomizers for basic types such as Int, Date, String, Bool, etc.
        /// </summary>
        public static IRandomBasic Basic => new RandomBasic(GetRandom);

        /// <summary>
        /// Offers Randomizers that selects a random value among a collection of items such as Arrays and IEnumerables.
        /// </summary>
        public static IRandomAmong Among => new RandomAmong();

        /// <summary>
        /// Offers Randomizers for internet related subjects such as e-mail, URL and usernames.
        /// </summary>
        public static IRandomInternet Internet => new RandomInternet();

        /// <summary>
        /// Offers Randomizers for People related subjects such as name, age, birth date, etc.
        /// </summary>
        public static IRandomPeople People => new RandomPeople(Language);

        /// <summary>
        /// Offers Randomizers for Words in general such as planets, exoplanets, scientists, file names, etc.
        /// </summary>
        public static IRandomWords Words => new RandomWords(Language);

        /// <summary>
        /// Offers Randomizers for Addresses in general such as Countries, States, Cities, etc.
        /// </summary>
        public static IRandomAddress Address => new RandomAddress(Language);

        /// <summary>
        /// Instantiate a new Random object with the given seed (from SedSeed method) or with a random seed.
        /// </summary>
        private static readonly Func<Random> GetRandom = delegate ()
        {
            int seed = Seed == null ? Guid.NewGuid().GetHashCode() : (int)Seed;
            return new Random(seed);
        };
    }
}
