using System;

namespace Lara.Randomizers
{
    internal class RandomBasic : IRandomBasic
    {
        public Guid Guid()
        {
            return System.Guid.NewGuid();
        }
    }
}
