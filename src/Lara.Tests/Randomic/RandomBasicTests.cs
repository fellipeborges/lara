using NUnit.Framework;
using System;
using Lara;

namespace RandomicTests
{
    public class RandomBasicTests
    {
        [Test]
        public void Guid()
        {
            string guid1 = Randomic.Basic.Guid().ToString();
            string guid2 = Randomic.Basic.Guid().ToString();

            Assert.IsTrue(System.Guid.TryParse(guid1, out Guid _));
            Assert.IsTrue(System.Guid.TryParse(guid2, out Guid _));
            Assert.AreNotEqual(guid1, guid2);
        }

    }
}
