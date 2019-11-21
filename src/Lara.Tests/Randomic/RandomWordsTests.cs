using Lara;
using NUnit.Framework;
using System;

namespace RandomicTests
{
    public class RandomWordsTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void Whatever()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string wordPtBr = Randomic.Words.Whatever();
            Assert.AreEqual("Conselho", wordPtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string wordEnUs = Randomic.Words.Whatever();
            Assert.AreEqual("Control", wordEnUs);
        }
    }
}
