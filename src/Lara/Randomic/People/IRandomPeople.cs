using System;

namespace Lara.Randomizers
{
    public interface IRandomPeople
    {
        /// <summary>
        /// Generates a random first name based on the previously selected language.
        /// </summary>
        string FirstName();

        /// <summary>
        /// Generates a random last name based on the previously selected language.
        /// </summary>
        string LastName();

        /// <summary>
        /// Generates a random full name (first name + last name) based on the previously selected language.
        /// </summary>
        string FullName();

        /// <summary>
        /// Generates a random prefix based on the previously selected language. Example: "Mr.", "Mrs.", "Miss." etc.
        /// </summary>
        string Prefix();

        /// <summary>
        /// Generates a random age between 0 and 100.
        /// </summary>
        int Age();

        /// <summary>
        /// Generates a random age based on the informed Age Group.
        /// </summary>
        /// <param name="ageGroup">Defines the age range of age that will be considered to randomize.</param>
        int Age(AgeGroup ageGroup);

        /// <summary>
        /// Generates a random birth date for a person that is between 0 and 100 years old.
        /// The calculation is based on current date.
        /// </summary>
        DateTime BirthDate();

        /// <summary>
        /// Generates a random birth date based on the informed Age Group.
        /// The calculation is based on current date.
        /// </summary>
        DateTime BirthDate(AgeGroup ageGroup);
    }
}
