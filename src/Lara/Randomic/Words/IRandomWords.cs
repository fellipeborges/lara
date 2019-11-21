using System;

namespace Lara.Randomizers
{
    public interface IRandomWords
    {
        /// <summary>
        /// Generates a random word.
        /// </summary>
        string Whatever();

        /// <summary>
        /// Generates a random Planet of the Solar System.
        /// </summary>
        string Planet();

        /// <summary>
        /// Generates a random Exo Planet.
        /// </summary>
        string ExoPlanet();
    }
}
