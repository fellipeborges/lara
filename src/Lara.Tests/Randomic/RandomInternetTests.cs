using Lara;
using NUnit.Framework;
using System;

namespace RandomicTests
{
    public class RandomInternetTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void Email()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string emailPtBr = Randomic.Internet.Email();
            Assert.AreEqual("denisecavalcanti@hotmail.org", emailPtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string emailEnUs = Randomic.Internet.Email();
            Assert.AreEqual("creagengisondo@hotmail.org", emailEnUs);
        }

        [Test]
        public void Url()
        {
            string url = Randomic.Internet.Url();
            Assert.AreEqual("http://www.mfyoiwsxfhbmqzji.org", url);
        }

        [Test]
        public void Uri()
        {
            Uri uri = Randomic.Internet.Uri();
            Assert.AreEqual("http://www.mfyoiwsxfhbmqzji.org/", uri.ToString());
        }
    }
}
