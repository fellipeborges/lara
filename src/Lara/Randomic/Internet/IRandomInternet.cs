﻿using System;

namespace Lara.Randomizers
{
    public interface IRandomInternet
    {
        /// <summary>
        /// Generates a random e-mail address in the following format: username@server.domain.
        /// Example: adalovelace@outlook.com
        /// </summary>
        string Email();

        /// <summary>
        /// Generates a random URL in the following format: protocol://server.domain
        /// Example: http://www.pudim.com.br
        /// </summary>
        string Url();

        /// <summary>
        /// Generates a random Uri in the following format: protocol://server.domain
        /// Example: http://www.pudim.com.br/
        /// </summary>
        Uri Uri();

        /// <summary>
        /// Generates a random Username.
        /// Examples: "adalovelace", "fellipe-borges", "tatiane_abdalla1990".
        /// </summary>
        string Username();
    }
}
