using NUnit.Framework;
using System;
using Lara;

namespace RandomicTests
{
    public class RandomBasicTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }


        [Test]
        public void TwoDifferentNumbersWhenSettingAndResetingSeed()
        {
            Randomic.SetSeed(1234);
            int number1 = Randomic.Basic.Int();

            Randomic.ResetSeed();
            int number2 = Randomic.Basic.Int();

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void Guid()
        {
            string guid1 = Randomic.Basic.Guid().ToString();
            string guid2 = Randomic.Basic.Guid().ToString();

            Assert.IsTrue(System.Guid.TryParse(guid1, out Guid _));
            Assert.IsTrue(System.Guid.TryParse(guid2, out Guid _));
            Assert.AreNotEqual(guid1, guid2);
        }

        [Test]
        public void Int()
        {
            // No parameters
            int noParameters = Randomic.Basic.Int();
            Assert.AreEqual(534011718, noParameters);

            // Between 1 and 1000
            int between1And1000 = Randomic.Basic.Int(1, 1000);
            Assert.AreEqual(249, between1And1000);

            // Negative
            int negative = Randomic.Basic.Int(int.MinValue, -1);
            Assert.AreEqual(-1613471930, negative);
        }

        [Test]
        public void Double()
        {
            // No parameters
            double noParameters = Randomic.Basic.Double();
            Assert.AreEqual(4.470298065951377E+307, noParameters);

            // Between 1.0 and 1000.0
            double between1And1000 = Randomic.Basic.Double(1.0, 1000.0);
            Assert.AreEqual(249.41991557293568, between1And1000);

            // Negative
            double negative = Randomic.Basic.Double(double.MinValue, -1.0);
            Assert.AreEqual(-1.3506633282671781E+308, negative);
        }

        [Test]
        public void Byte()
        {
            byte number = Randomic.Basic.Byte();
            Assert.AreEqual(63, number);
        }

        [Test]
        public void String()
        {
            string randomStr = Randomic.Basic.String();
            Assert.AreEqual("MFYoiWSxFhBMQzji", randomStr);

            string randomStrLength32 = Randomic.Basic.String(32);
            Assert.AreEqual("MFYoiWSxFhBMQzjiOfkkxEITpIpPqucl", randomStrLength32);
        }

        [Test]
        public void Alphanumeric()
        {
            string randomAlpha = Randomic.Basic.Alphanumeric();
            Assert.AreEqual("PGcvoaV7GnBPT0qo", randomAlpha);

            string randomAlpha32 = Randomic.Basic.Alphanumeric(32);
            Assert.AreEqual("PGcvoaV7GnBPT0qoRmrr7FJXxKxTz3is", randomAlpha32);
        }

        [Test]
        public void Date()
        {
            // No parameters
            DateTime noParams = Randomic.Basic.Date();
            Assert.AreEqual(new DateTime(2002, 04, 30), noParams);

            // With parameters
            DateTime withParams = Randomic.Basic.Date(new DateTime(1986, 01, 01), new DateTime(1986, 05, 18));
            Assert.AreEqual(new DateTime(1986, 02, 04), withParams);
        }

        [Test]
        public void DateTime()
        {
            // No parameters
            DateTime noParams = Randomic.Basic.DateTime();
            Assert.AreEqual(new DateTime(2002, 04, 30, 05, 58, 04, 717), noParams);

            // With parameters
            DateTime withParams = Randomic.Basic.DateTime(new DateTime(1986, 05, 18, 08, 40, 10), new DateTime(1986, 05, 18, 08, 40, 20));
            Assert.AreEqual(new DateTime(1986, 05, 18, 08, 40, 12, 487), withParams);
        }

        [Test]
        public void Boolean()
        {
            bool value = Randomic.Basic.Boolean();
            Assert.IsFalse(value);
        }

        [Test]
        public void BooleanWithProbability()
        {
            // Invalid parameters (less than 0.0 and greater than 1.0)
            Assert.Throws<ArgumentException>(() => Randomic.Basic.Boolean(-0.1));
            Assert.Throws<ArgumentException>(() => Randomic.Basic.Boolean(1.1));

            // Always true
            bool valueTrue = Randomic.Basic.Boolean(1.0);
            Assert.IsTrue(valueTrue);
            
            // Always false
            bool valueFalse = Randomic.Basic.Boolean(0.0);
            Assert.IsFalse(valueFalse);

            // Randomic value
            bool randomValue = Randomic.Basic.Boolean(0.5);
            Assert.IsTrue(randomValue);
        }

        [Test]
        public void EvenOdd()
        {
            const string VALUE_FOR_EVEN = "AAA";
            const string VALUE_FOR_ODD = "BBB";

            // Even
            string evenValue = Randomic.Basic.EvenOdd(0, VALUE_FOR_EVEN, VALUE_FOR_ODD);
            Assert.AreEqual(VALUE_FOR_EVEN, evenValue);
            
            // Odd
            string oddValue = Randomic.Basic.EvenOdd(1, VALUE_FOR_EVEN, VALUE_FOR_ODD);
            Assert.AreEqual(VALUE_FOR_ODD, oddValue);
        }
    }
}
