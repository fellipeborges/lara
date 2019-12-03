using Lara;
using NUnit.Framework;

namespace Extensions
{
    public class TextTests
    {
        [Test]
        public void Left()
        {
            const string TEXT = "Lucca Abdalla";
            // Normal
            string expected = "Lucca";
            string sliced = TEXT.Left(5);
            Assert.AreEqual(expected, sliced);

            // Length greater than text
            expected = TEXT;
            sliced = TEXT.Left(100);
            Assert.AreEqual(expected, sliced);

            // Zero length
            expected = "";
            sliced = TEXT.Left(0);
            Assert.AreEqual(expected, sliced);

            // Empty string
            expected = "";
            sliced = "".Left(5);
            Assert.AreEqual(expected, sliced);
        }

        [Test]
        public void Right()
        {
            const string TEXT = "Lucca Abdalla";

            // Normal
            string expected = "Abdalla";
            string sliced = TEXT.Right(7);
            Assert.AreEqual(expected, sliced);

            // Length greater than text
            expected = TEXT;
            sliced = TEXT.Right(100);
            Assert.AreEqual(expected, sliced);

            // Zero length
            expected = "";
            sliced = TEXT.Right(0);
            Assert.AreEqual(expected, sliced);

            // Empty string
            expected = "";
            sliced = "".Right(5);
            Assert.AreEqual(expected, sliced);
        }

        [Test]
        public void RemoveAccentuation()
        {
            const string TEXT = "áéíóúãõàèìòù";

            string expected = "aeiouaoaeiou";
            Assert.AreEqual(expected, TEXT.RemoveAccentuation());
        }
    }
}
