using System;
using System.Collections;
using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class RandomWords : IRandomWords
    {
        private readonly Language Language;

        public RandomWords(Language language)
        {
            Language = language;
        }

        public string Noun()
        {
            return GetRandomFromCollection(new WordsCollection().GetCollection(Language));
        }

        public string Planet()
        {
            return GetRandomFromCollection(new PlanetsCollection().GetCollection(Language));
        }

        public string ExoPlanet()
        {
            return GetRandomFromCollection(new ExoPlanetsCollection().GetCollection());
        }

        public string FamousPerson()
        {
            return GetRandomFromCollection(new FamousPeopleCollection().GetCollection());
        }

        public string Brand()
        {
            return GetRandomFromCollection(new BrandCollection().GetCollection());
        }

        private string GetRandomFromCollection(List<string> collection)
        {
            return Randomic.Among.Strings(collection);
        }
    }
}
