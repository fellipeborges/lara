using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class PrefixCollection
    {
        /// <summary>
        ///  Returns a list of name prefixes based on the informed language
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<string> GetCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetEnUs(),
                Language.PtBr => GetPtBr(),
                _ => GetEnUs(),
            };
        }

        /// <summary>
        /// Returns a list of prefixes in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                "Mr.",
                "Mrs.",
                "Miss.",
                "Ms.",
                "Mx.",
                "Dr.",
                "Sir",
                "Lady",
                "Lord"
            };
        }

        /// <summary>
        /// Returns a list of prefixes in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Sr.",
                "Sra.",
                "Srta.",
                "Dr.",
                "V. Ex.",
            };
        }
    }
}
