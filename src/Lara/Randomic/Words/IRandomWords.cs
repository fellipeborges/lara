using System;

namespace Lara.Randomizers
{
    public interface IRandomWords
    {
        /// <summary>
        /// Returns a random noun.
        /// Examples: "Advice", "Economics", etc.
        /// </summary>
        string Noun();

        /// <summary>
        /// Returns a random Planet of the Solar System.
        /// Examples: "Earth", "Venus", etc.
        /// </summary>
        string Planet();

        /// <summary>
        /// Returns a random Exo Planet.
        /// Examples: "Arion", "Galileo", etc.
        /// </summary>
        string ExoPlanet();

        /// <summary>
        /// Returns a random famous person name.
        /// Examples: "Albert Einstein", "Anne Frank", etc.
        /// </summary>
        string FamousPerson();

        /// <summary>
        /// Returns a random brand.
        /// Examples: "Microsoft", "Twitter", etc.
        /// </summary>
        string Brand();
    }
}
