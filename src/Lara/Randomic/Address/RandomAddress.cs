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
    }
}
