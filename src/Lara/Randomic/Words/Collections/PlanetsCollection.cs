using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class PlanetsCollection
    {
        /// <summary>
        ///  Returns a list of Planets based on the informed language.
        /// </summary>
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
        /// Returns a list of Planets in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Uranus",
                "Neptune",
                "Pluto"
            };
        }

        /// <summary>
        /// Returns a list of Planets in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Mercúrio",
                "Vênus",
                "Terra",
                "Marte",
                "Júpiter",
                "Saturno",
                "Urano",
                "Netuno",
                "Plutão"
            };
        }
    }
}
