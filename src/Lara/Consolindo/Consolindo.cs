using System;

namespace Lara
{
    /// <summary>
    /// A set of functions to make it easyer to write colorful texts in console.
    /// </summary>
    public static class Consolindo
    {
        private const string TITLE_HOLDER = "----------------------------------------------------------------------------------------------------";
        private static readonly object _lock = new object();
        private static ConsoleColor _defaultConsoleColor = ConsoleColor.White;

        /// <summary>
        /// Configures the default color to be used in the console.
        /// </summary>
        public static void SetDefaultColor(ConsoleColor color)
        {
            _defaultConsoleColor = color;
        }

        /// <summary>
        /// Writes a text in green color in console and configures back its color to the default color.
        /// </summary>
        public static void WriteGreen(string text)
        {
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ForegroundColor = _defaultConsoleColor;
            }
        }

        /// <summary>
        /// Writes a text in red color in console and configures back its color to the default color.
        /// </summary>
        public static void WriteRed(string text)
        {
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ForegroundColor = _defaultConsoleColor;
            }
        }

        /// <summary>
        /// Writes a text in yellow color in console and configures back its color to the default color.
        /// </summary>
        public static void WriteYellow(string text)
        {
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(text);
                Console.ForegroundColor = _defaultConsoleColor;
            }
        }

        /// <summary>
        /// Writes a text in white color in console.
        /// </summary>
        public static void Write(string text)
        {
            lock (_lock)
            {
                Console.ForegroundColor = _defaultConsoleColor;
                Console.WriteLine(text);
            }
        }

        /// <summary>
        /// Writes a text in the given color in console and configures back its color to the default color.
        /// </summary>
        public static void Write(string text, ConsoleColor color)
        {
            lock (_lock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = _defaultConsoleColor;
            }
        }

        /// <summary>
        /// Writes a text in a format of title (surrounded by dashses)
        /// </summary>
        public static void WriteTitle(string text)
        {
            WriteTitle(text, _defaultConsoleColor);
        }

        /// <summary>
        /// Writes a text in a format of title (surrounded by dashses)
        /// </summary>
        public static void WriteTitle(string text, ConsoleColor color)
        {
            Write(TITLE_HOLDER, color);
            Write(text, color);
            Write(TITLE_HOLDER, color);
        }

        /// <summary>
        /// Starts a new line in Console.
        /// </summary>
        public static void NewLine() => Console.WriteLine();

        /// <summary>
        /// Waits until user types any key to continue.
        /// </summary>
        public static void Wait() => Console.ReadKey();

        /// <summary>
        /// Returns the key typed by user.
        /// </summary>
        public static ConsoleKeyInfo ReadKey() => Console.ReadKey();

        /// <summary>
        /// Writes the text in the console and returns the key typed by user.
        /// </summary>
        public static ConsoleKeyInfo ReadKey(string text)
        {
            Write(text);
            return Console.ReadKey();
        }

        /// <summary>
        /// Writes the text in the console and returns the key typed by user.
        /// </summary>
        public static ConsoleKeyInfo ReadKey(string text, ConsoleColor color)
        {
            Write(text, color);
            return Console.ReadKey();
        }

        /// <summary>
        /// Returns the line typed by user.
        /// </summary>
        public static string ReadLine() => Console.ReadLine();

        /// <summary>
        /// Writes the text in the console and returns the key typed by user.
        /// </summary>
        public static string ReadLine(string text)
        {
            Write(text);
            return Console.ReadLine();
        }

        /// <summary>
        /// Writes the text in the console and returns the key typed by user.
        /// </summary>
        public static string ReadLine(string text, ConsoleColor color)
        {
            Write(text, color);
            return Console.ReadLine();
        }
    }
}
