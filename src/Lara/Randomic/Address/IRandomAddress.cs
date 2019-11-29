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
        /// Example: "House A2", "Apartment B", etc.
        /// </summary>
        string Complement();

        /// <summary>
        /// Generates a random complement.
        /// Example: "House A2", "Apartment B", etc.
        /// </summary>
        /// <param name="probability">The probability of generating a Complement.
        /// Must be a value from 0.0 (never generates) to 1.0 (always generates) with increments of 10% (0.1, 0.2, 0.3, etc)</param>
        string Complement(double probability);

        /// <summary>
        /// Returns a random Neighborhood.
        /// Example: "Vila Formosa", "Tatuapé", etc.
        /// Not avaialble in EnUs.
        /// </summary>
        string Neighborhood();

        /// <summary>
        /// Returns a random City.
        /// Example: "New York", "San Francisco", etc.
        /// </summary>
        string City();

        /// <summary>
        /// Returns a random State with Name, Abbreviation and Capital.
        /// Example: "Florida, FL, Tallahassee".
        /// </summary>
        IRandomState State();

        /// <summary>
        /// Generates a random Zip Code.
        /// Examples: "50613", "45125"
        /// </summary>
        string ZipCode();

        /// <summary>
        /// Generates a random Phone with Country Code, Area Code and Number.
        /// Examples: "+1 866 918-6329", "+55 11 2302-1409"
        /// </summary>
        IRandomPhone Phone();

        /// <summary>
        /// Generates a formated full address. The formating is based in the selected Language.
        /// Example: "58 Central Drive, Cedar Falls, IA 50613"
        /// </summary>
        string FullAddress();
    }
}
