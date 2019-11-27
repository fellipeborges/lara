using System;

namespace Lara.Randomizers
{
    public interface IRandomAddress
    {
        /// <summary>
        /// Returns a random country name.
        /// Example: "Brazil", "Argentina", etc.
        /// </summary>
        string Country();
    }
}
