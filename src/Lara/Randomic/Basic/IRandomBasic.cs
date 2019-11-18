using System;

namespace Lara.Randomizers
{
    public interface IRandomBasic
    {
        /// <summary>
        /// Returns a random new Guid.
        /// </summary>
        Guid Guid();
    }
}
