using Lara.Randomizers;

namespace Lara
{
    public static class Randomic
    {
        /// <summary>
        /// Offers Randomizers for basic types such as Int, Date, String, Bool, etc.
        /// </summary>
        public static IRandomBasic Basic => new RandomBasic();
    }
}
