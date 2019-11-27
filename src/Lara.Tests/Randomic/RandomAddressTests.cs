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

        [Test]
        public void Type()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.Type();
            Assert.AreEqual("Bosque", ptBr);
            string ptBrAbbr = Randomic.Address.TypeAbbreviated();
            Assert.AreEqual("Bq.", ptBrAbbr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.Type();
            Assert.AreEqual("Street", enUs);
            string enUsAbbr = Randomic.Address.TypeAbbreviated();
            Assert.AreEqual("St.", enUsAbbr);
        }

        [Test]
        public void Name()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.Name();
            Assert.AreEqual("Denise Galileo", ptBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.Name();
            Assert.AreEqual("Creagen Galileo", enUs);
        }

        [Test]
        public void Number()
        {
            string number = Randomic.Address.Number();
            Assert.AreEqual("24867", number);
        }
    }
}
