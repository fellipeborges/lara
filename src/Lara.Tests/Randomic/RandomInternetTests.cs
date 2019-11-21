using Lara;
using NUnit.Framework;

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
            string email = Randomic.Internet.Email();
            Assert.AreEqual("X", email);
        }
    }
}
