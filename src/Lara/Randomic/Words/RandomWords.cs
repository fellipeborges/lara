using System;
using System.Collections.Generic;
using System.Linq;

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

        public string LoremIpsum(int paragraphs)
        {
            if (paragraphs == 0)
                throw new ArgumentException("Invalid paragraphs number: " + paragraphs);

            var collection = new LoremIpsumCollection().GetCollection();
            int collectionIndex = 0;
            string loremReturn = "";
            Enumerable.Range(1, paragraphs).ToList().ForEach(p =>
            {
                loremReturn += collection[collectionIndex];
                collectionIndex++;

                if (p != paragraphs)
                    loremReturn += Environment.NewLine;

                if (collectionIndex == collection.Count)
                    collectionIndex = 0;
            });

            return loremReturn;
        }

        private string GetRandomFromCollection(List<string> collection)
        {
            return Randomic.Among.Strings(collection);
        }
    }
}
