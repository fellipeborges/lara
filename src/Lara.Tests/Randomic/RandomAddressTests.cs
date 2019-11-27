using Lara;
using NUnit.Framework;
using System;

namespace RandomicTests
{
    public class RandomAddressTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void Country()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.Country();
            Assert.AreEqual("Dinamarca", ptBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.Country();
            Assert.AreEqual("Dominica", enUs);
        }
    }
}
