using System;

namespace Lara.Randomizers
{
    internal class RandomWords : IRandomWords
    {
        private readonly Language Language;

        public RandomWords(Language language)
        {
            Language = language;
        }

        public string Whatever()
        {
            var collection = new WordsCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }
    }
}
