using Lara;
using NUnit.Framework;
using System;

namespace RandomicTests
{
    public class RandomPeopleTests
    {
        private const string PT_BR_FIRST_NAME = "Denise";
        private const string PT_BR_LAST_NAME = "Cavalcanti";
        private const string EN_US_FIRST_NAME = "Creagen";
        private const string EN_US_LAST_NAME = "Gisondo";

        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void FirstName()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string namePtBr = Randomic.People.FirstName();
            Assert.AreEqual(PT_BR_FIRST_NAME, namePtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string nameEnUs = Randomic.People.FirstName();
            Assert.AreEqual(EN_US_FIRST_NAME, nameEnUs);
        }

        [Test]
        public void LastName()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string namePtBr = Randomic.People.LastName();
            Assert.AreEqual(PT_BR_LAST_NAME, namePtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string nameEnUs = Randomic.People.LastName();
            Assert.AreEqual(EN_US_LAST_NAME, nameEnUs);
        }

        [Test]
        public void FullName()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string namePtBr = Randomic.People.FullName();
            Assert.AreEqual($"{PT_BR_FIRST_NAME} {PT_BR_LAST_NAME}", namePtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string nameEnUs = Randomic.People.FullName();
            Assert.AreEqual($"{EN_US_FIRST_NAME} {EN_US_LAST_NAME}", nameEnUs);
        }

        [Test]
        public void Prefix()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string prefixPtBr = Randomic.People.Prefix();
            Assert.AreEqual("Sr.", prefixPtBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string prefixEnUs = Randomic.People.Prefix();
            Assert.AreEqual("Mrs.", prefixEnUs);
        }

        [Test]
        public void Age()
        {
            // General
            int age = Randomic.People.Age();
            Assert.AreEqual(24, age);

            // Child
            int ageChild = Randomic.People.Age(AgeGroup.Child);
            Assert.AreEqual(2, ageChild);

            // Teenager
            int ageTeenager = Randomic.People.Age(AgeGroup.Teenager);
            Assert.AreEqual(14, ageTeenager);

            // Adult
            int ageAdult = Randomic.People.Age(AgeGroup.Adult);
            Assert.AreEqual(29, ageAdult);

            // Elder
            int ageElder = Randomic.People.Age(AgeGroup.Elder);
            Assert.AreEqual(69, ageElder);
        }

        [Test]
        public void BirthDate()
        {
            // General
            double years = (DateTime.Today - Randomic.People.BirthDate()).TotalDays / 365;
            Assert.IsTrue(years >= 0 && years <= 100);

            // Child
            double yearsChild = (DateTime.Today - Randomic.People.BirthDate(AgeGroup.Child)).TotalDays / 365;
            Assert.IsTrue(yearsChild >= 0 && yearsChild <= 12);

            // Teenager
            double yearsTeenager = (DateTime.Today - Randomic.People.BirthDate(AgeGroup.Teenager)).TotalDays / 365;
            Assert.IsTrue(yearsTeenager >= 13 && yearsTeenager <= 19);

            // Adult
            double yearsAdult = (DateTime.Today - Randomic.People.BirthDate(AgeGroup.Adult)).TotalDays / 365;
            Assert.IsTrue(yearsAdult >= 20 && yearsAdult <= 59);

            // Elder
            double yearsElder = (DateTime.Today - Randomic.People.BirthDate(AgeGroup.Elder)).TotalDays / 365;
            Assert.IsTrue(yearsElder >= 60 && yearsElder <= 100);
        }
    }
}
