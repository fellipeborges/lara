using System;
using System.Collections.Generic;
using System.Linq;

namespace Lara.Randomizers
{
    internal class RandomAmong
    {
        private readonly Func<int, int, int> GetRandomInt;

        public RandomAmong(Func<int, int, int> getRandomIntFunction)
        {
            GetRandomInt = getRandomIntFunction;
        }

        public TReturn Among<TReturn>(params TReturn[] options)
        {
            if (options == null || options.Length == 0)
                return default;

            int randomPosition = GetRandomInt(0, options.Length - 1);
            return options[randomPosition];
        }

        public TReturn Among<TReturn>(IEnumerable<TReturn> collection)
        {
            if (collection == null || collection.Count() == 0)
                return default;

            int randomPosition = GetRandomInt(0, collection.Count() - 1);
            return collection.ToList()[randomPosition];
        }
    }
}
