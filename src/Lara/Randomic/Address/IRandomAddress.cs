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

        /// <summary>
        /// Returns a random Type.
        /// Example: "Street", "Avenue", etc.
        /// </summary>
        string Type();

        /// <summary>
        /// Returns a random abbreviated Type.
        /// Example: "St.", "Av.", etc.
        /// </summary>
        string TypeAbbreviated();
    }
}
