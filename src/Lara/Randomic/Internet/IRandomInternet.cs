using System;

namespace Lara.Randomizers
{
    public interface IRandomInternet
    {
        /// <summary>
        /// Generates a random e-mail address in the following format: username@server.domain
        /// </summary>
        string Email();
    }
}
