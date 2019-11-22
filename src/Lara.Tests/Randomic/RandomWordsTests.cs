using Lara;
using NUnit.Framework;
using System;
using System.Linq;

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
        public void Noun()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string wordPtBr = Randomic.Words.Noun();
            Assert.AreEqual("Conselho", wordPtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string wordEnUs = Randomic.Words.Noun();
            Assert.AreEqual("Control", wordEnUs);
        }

        [Test]
        public void Planet()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string planetPtBr = Randomic.Words.Planet();
            Assert.AreEqual("Vênus", planetPtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string planetEnUs = Randomic.Words.Planet();
            Assert.AreEqual("Venus", planetEnUs);
        }

        [Test]
        public void ExoPlanet()
        {
            string exoPlanet = Randomic.Words.ExoPlanet();
            Assert.AreEqual("Galileo", exoPlanet);
        }

        [Test]
        public void FamousPerson()
        {
            string famous = Randomic.Words.FamousPerson();
            Assert.AreEqual("Emmeline Pankhurst", famous);
        }

        [Test]
        public void Brand()
        {
            string brand = Randomic.Words.Brand();
            Assert.AreEqual("DHL", brand);
        }

        [Test]
        public void LoremIpsum()
        {
            // 1 paragraph
            string lorem = Randomic.Words.LoremIpsum();
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi tristique, enim ut viverra feugiat, felis lorem interdum quam, vel elementum sem nisl quis erat. Suspendisse et ultrices enim, vel vehicula lorem. Ut at urna sem. Etiam iaculis felis ut posuere rhoncus. Donec viverra tempus lorem nec blandit. Curabitur placerat magna at sollicitudin accumsan. In hac habitasse platea dictumst. Fusce lacinia, urna in ultrices iaculis, nibh nisi egestas massa, sed mollis nulla tortor id sapien. Suspendisse eget rhoncus nunc, id bibendum nibh. Vestibulum a purus a enim tristique vestibulum. In aliquet porttitor sapien, quis tristique velit finibus ac. Praesent suscipit vestibulum nibh, a commodo tellus.", lorem);
            Assert.AreEqual(0, lorem.Count(s => s.ToString() == Environment.NewLine));

            // 15 paragraphs
            string lorem2 = Randomic.Words.LoremIpsum(15);
            Assert.IsTrue(lorem2.Contains(Environment.NewLine));

            // 0 paragraphs
            Assert.Throws<ArgumentException>(() => Randomic.Words.LoremIpsum(0));
        }
    }
}
