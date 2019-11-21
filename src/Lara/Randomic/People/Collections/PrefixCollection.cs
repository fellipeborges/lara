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
                Language.EnUS => GetEnUS(),
                Language.PtBR => GetPtBR(),
                _ => GetEnUS(),
            };
        }

        /// <summary>
        /// Returns a list of prefixes in EnUS.
        /// </summary>
        private List<string> GetEnUS()
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
        /// Returns a list of prefixes in PtBR.
        /// </summary>
        private List<string> GetPtBR()
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
