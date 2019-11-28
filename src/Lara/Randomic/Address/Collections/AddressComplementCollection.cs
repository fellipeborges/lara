using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class AddressComplementCollection
    {
        /// <summary>
        ///  Returns a list of Address Complements. Exeamples: "House", "Apartment", etc..
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
        /// Returns a list of address complements in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                "Apt.",
                "House"
            };
        }

        /// <summary>
        /// Returns a list of address complements in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Frente",
                "Fundos",
                "Apto.",
                "Casa",
                "Lote",
                "Bloco"
            };
        }
    }
}
