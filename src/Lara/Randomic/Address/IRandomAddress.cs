using System;

namespace Lara.Randomizers
{
    public interface IRandomAddress
    {
        /// <summary>
        /// Returns a random country name.
        /// Example: "Brazil", "Argentina", etc.
        /// </summary>
        string Country();

        /// <summary>
        /// Returns a random Type.
        /// Example: "Street", "Avenue", etc.
        /// </summary>
        string Type();

        /// <summary>
        /// Returns a random abbreviated Type.
        /// Example: "St.", "Av.", etc.
        /// </summary>
        string TypeAbbreviated();

        /// <summary>
        /// Generates a random name.
        /// Example: "Richard Ballman", "Galileo Mercury", etc.
        /// </summary>
        string Name();

        /// <summary>
        /// Generates a random number.
        /// Example: "126", "3B", etc.
        /// </summary>
        string Number();

        /// <summary>
        /// Generates a random complement.
        /// Example: "House A", "Apartment B", etc.
        /// </summary>
        string Complement();

        /// <summary>
        /// Generates a random complement.
        /// Example: "House A", "Apartment B", etc.
        /// </summary>
        /// <param name="probability">The probability of generating a Complement.
        /// Must be a value from 0.0 (never generates) to 1.0 (always generates) with increments of 10% (0.1, 0.2, 0.3, etc)</param>
        string Complement(double probability);
    }
}
