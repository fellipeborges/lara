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
    }
}
