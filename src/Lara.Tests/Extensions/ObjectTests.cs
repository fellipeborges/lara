using Lara;
using NUnit.Framework;

namespace Extensions
{
    public class ObjectTests
    {
        [Test]
        public void EmptyIfNull()
        {
            // Null
            object isNull = null;
            Assert.AreEqual("", isNull.EmptyIfNull());

            // Not Null
            object notNull = "X";
            Assert.AreEqual(notNull.ToString(), notNull.EmptyIfNull());
        }
    }
}
