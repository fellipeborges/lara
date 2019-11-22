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

        public string Planet()
        {
            var collection = new PlanetsCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string ExoPlanet()
        {
            var collection = new ExoPlanetsCollection().GetCollection();
            return Randomic.Among.Strings(collection);
        }

        public string FamousPerson()
        {
            var collection = new FamousPeopleCollection().GetCollection();
            return Randomic.Among.Strings(collection);
        }
    }
}
