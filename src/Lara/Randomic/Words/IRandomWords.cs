using System;

namespace Lara.Randomizers
{
    public interface IRandomWords
    {
        /// <summary>
        /// Returns a random word.
        /// </summary>
        string Whatever();

        /// <summary>
        /// Returns a random Planet of the Solar System.
        /// </summary>
        string Planet();

        /// <summary>
        /// Returns a random Exo Planet.
        /// </summary>
        string ExoPlanet();

        /// <summary>
        /// Returns a random famous person name.
        /// </summary>
        string FamousPerson();
    }
}
