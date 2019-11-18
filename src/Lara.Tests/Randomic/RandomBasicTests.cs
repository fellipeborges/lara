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

        [Test]
        public void Int()
        {
            // No parameters
            int noParameters = Randomic.Basic.Int();
            Assert.IsTrue(noParameters >= 0);

            // Between 1 and 1000
            int between1And1000 = Randomic.Basic.Int(1, 1000);
            Assert.IsTrue(between1And1000 >= 1 && between1And1000 <= 1000);

            // Negative
            int negative = Randomic.Basic.Int(int.MinValue, -1);
            Assert.IsTrue(negative <= -1);
        }

        [Test]
        public void Double()
        {
            // No parameters
            double noParameters = Randomic.Basic.Double();
            Assert.IsTrue(noParameters >= 0);

            // Between 1.0 and 1000.0
            double between1And1000 = Randomic.Basic.Double(1.0, 1000.0);
            Assert.IsTrue(between1And1000 >= 1.0 && between1And1000 <= 1000.0);

            // Negative
            double negative = Randomic.Basic.Double(double.MinValue, -1.0);
            Assert.IsTrue(negative <= -1.0);
        }

        [Test]
        public void Byte()
        {
            byte number = Randomic.Basic.Byte();
            Assert.IsTrue(number >= 0 && number <= 255);
        }

        [Test]
        public void String()
        {
            string randomStr = Randomic.Basic.String();
            Assert.AreEqual(16, randomStr.Length);

            string randomStrLength32 = Randomic.Basic.String(32);
            Assert.AreEqual(32, randomStrLength32.Length);
        }

        [Test]
        public void Alphanumeric()
        {
            string randomAlpha = Randomic.Basic.Alphanumeric();
            Assert.AreEqual(16, randomAlpha.Length);

            string randomAlpha32 = Randomic.Basic.Alphanumeric(32);
            Assert.AreEqual(32, randomAlpha32.Length);
        }

        [Test]
        public void Date()
        {
            // No parameters
            DateTime MIN_DATE = new DateTime(1970, 01, 01);
            DateTime MAX_DATE = new DateTime(2099, 12, 31);
            DateTime noParams = Randomic.Basic.Date();
            Assert.IsTrue(noParams >= MIN_DATE && noParams <= MAX_DATE);
            Assert.AreEqual(00, noParams.Hour);
            Assert.AreEqual(00, noParams.Minute);
            Assert.AreEqual(00, noParams.Second);

            // With parameters
            DateTime INI_DATE = new DateTime(1986, 01, 01);
            DateTime END_DATE = new DateTime(1986, 05, 18);
            DateTime withParams = Randomic.Basic.Date(INI_DATE, END_DATE);
            Assert.IsTrue(withParams >= INI_DATE && withParams <= END_DATE);
            Assert.AreEqual(00, withParams.Hour);
            Assert.AreEqual(00, withParams.Minute);
            Assert.AreEqual(00, withParams.Second);
        }

        [Test]
        public void DateTime()
        {
            // No parameters
            DateTime MIN_DATETIME = new DateTime(1970, 01, 01, 00, 00, 00);
            DateTime MAX_DATETME = new DateTime(2099, 12, 31, 23, 59, 59);
            DateTime noParams = Randomic.Basic.DateTime();
            Assert.IsTrue(noParams >= MIN_DATETIME && noParams <= MAX_DATETME);
            Assert.AreNotEqual(00, noParams.Hour);
            Assert.AreNotEqual(00, noParams.Minute);
            Assert.AreNotEqual(00, noParams.Second);

            // With parameters
            DateTime INI_DATETIME = new DateTime(1986, 05, 18, 08, 40, 10);
            DateTime END_DATETIME = new DateTime(1986, 05, 18, 08, 40, 20);
            DateTime withParams = Randomic.Basic.DateTime(INI_DATETIME, END_DATETIME);
            Assert.IsTrue(withParams >= INI_DATETIME && withParams <= END_DATETIME);
            Assert.AreNotEqual(00, withParams.Hour);
            Assert.AreNotEqual(00, withParams.Minute);
            Assert.AreNotEqual(00, withParams.Second);
        }
    }
}
