using System.Collections.Generic;
using System.Linq;

namespace Lara.Randomizers
{
    internal class RandomAmong : IRandomAmong
    {
        public string Strings(params string[] options)
        {
            return Among(options);
        }

        public string Strings(IEnumerable<string> collection)
        {
            return Among(collection);
        }

        public int Ints(params int[] options)
        {
            return Among(options);
        }

        public int Ints(IEnumerable<int> collection)
        {
            return Among(collection);
        }

        public TReturn Other<TReturn>(params TReturn[] options)
        {
            return Among(options);
        }

        public TReturn Other<TReturn>(IEnumerable<TReturn> collection)
        {
            return Among(collection);
        }

        private TReturn Among<TReturn>(params TReturn[] options)
        {
            if (options == null || options.Length == 0)
                return default;

            int randomPosition = Randomic.Basic.Int(0, options.Length - 1);
            return options[randomPosition];
        }

        private TReturn Among<TReturn>(IEnumerable<TReturn> collection)
        {
            if (collection == null || collection.Count() == 0)
                return default;

            int randomPosition = Randomic.Basic.Int(0, collection.Count() - 1);
            return collection.ToList()[randomPosition];
        }
    }
}
