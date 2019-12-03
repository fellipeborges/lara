using Lara;
using NUnit.Framework;
using System;

namespace Extensions
{
    public class DateTimeTests
    {
        [Test]
        public void FirstDayOfMonth()
        {
            DateTime expected = new DateTime(2019, 01, 01);
            DateTime calculated = new DateTime(2019, 01, 23).FirstDayOfMonth();
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void LastDayOfMonth()
        {
            // 31 days month
            DateTime expected = new DateTime(2019, 01, 31);
            DateTime calculated = new DateTime(2019, 01, 23).LastDayOfMonth();
            Assert.AreEqual(expected, calculated);

            // 30 day month
            expected = new DateTime(2019, 04, 30);
            calculated = new DateTime(2019, 04, 24).LastDayOfMonth();
            Assert.AreEqual(expected, calculated);

            // 29 day month
            expected = new DateTime(2020, 02, 29);
            calculated = new DateTime(2020, 02, 01).LastDayOfMonth();
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_Brazilian()
        {
            string expected = "18/05/1986";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.Brazilian);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_BrazilianWithTime()
        {
            string expected = "18/05/1986 15:40:41";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.BrazilianWithTime);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_American()
        {
            string expected = "05/18/1986";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.American);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_AmericanWithTime()
        {
            string expected = "05/18/1986 03:40:41 PM";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.AmericanWithTime);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_YearMonthDay()
        {
            string expected = "1986-05-18";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.YearMonthDay);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_YearMonthDayWithTime()
        {
            string expected = "1986-05-18 15:40:41";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.YearMonthDayWithTime);
            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void ToFormat_MonthYear()
        {
            string expected = "05/1986";
            string calculated = new DateTime(1986, 05, 18, 15, 40, 41).ToFormat(PreDefinedFormat.MonthYear);
            Assert.AreEqual(expected, calculated);
        }
    }
}