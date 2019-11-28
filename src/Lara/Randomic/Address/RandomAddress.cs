using System;

namespace Lara.Randomizers
{
    internal class RandomAddress : IRandomAddress
    {
        private readonly Language Language;

        public RandomAddress(Language language)
        {
            Language = language;
        }

        public string Country()
        {
            var collection = new CountryCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string Type()
        {
            var collection = new AddressTypeCollection().GetTypeCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string TypeAbbreviated()
        {
            var collection = new AddressTypeCollection().GetAbbreviatedTypeCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string Name()
        {
            string partA = Randomic.Among.Strings(
                Randomic.People.FirstName(),
                Randomic.People.LastName(),
                Randomic.Words.Planet(),
                Randomic.Words.ExoPlanet(),
                Randomic.Words.FamousPerson());

            string partB = Randomic.Among.Strings(
                Randomic.Words.ExoPlanet(),
                Randomic.Words.FamousPerson(),
                Randomic.People.LastName(),
                Randomic.People.FirstName(),
                Randomic.Words.Planet());

            string name = $"{partA} {partB}";
            return name;
        }

        public string Number()
        {
            // 20% of possibility of showing the letter
            bool mustShowLetter = Randomic.Basic.Boolean(0.2);
            string number = Randomic.Basic.Int(1, 99999).ToString();

            if (mustShowLetter)
            {
                string letter = Randomic.Basic.String(1);
                number = $"{number} {letter}";
            }

            return number;
        }

        public string Complement()
        {
            var collection = new AddressComplementCollection().GetCollection(Language);
            string complement = Randomic.Among.Strings(collection);
            string number = Randomic.Basic.Int(1, 999).ToString();
            string letter = Randomic.Among.Strings("", Randomic.Basic.String(1));
            string retValue = $"{complement} {number}{letter}";

            return retValue;
        }

        public string Complement(double probability)
        {
            string complement = Randomic.Basic.Boolean(probability) ?
                Complement() :
                "";

            return complement;
        }
    }
}
