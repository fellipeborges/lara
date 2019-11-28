﻿using Lara;
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

        [Test]
        public void Complement()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.Complement();
            Assert.AreEqual("Fundos 249", ptBr);

            // EnUs
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.Complement();
            Assert.AreEqual("Apt. 249", enUs);
        }

        [Test]
        public void ComplementWithProbability()
        {
            // Always generates
            string always = Randomic.Address.Complement(1.0);
            Assert.AreEqual("Apt. 249", always);

            // Never generates
            string never = Randomic.Address.Complement(0.0);
            Assert.AreEqual("", never);

            // 50/50 chance of generate
            string fiftyFifty = Randomic.Address.Complement(0.5);
            Assert.AreEqual("Apt. 249", fiftyFifty);
        }

        [Test]
        public void Neighborhood()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.Neighborhood();
            Assert.AreEqual("Jardim Assunção", ptBr);

            // EnUs (not available)
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.Neighborhood();
            Assert.AreEqual("", enUs);
        }

        [Test]
        public void City()
        {
            // PtBr
            Randomic.SetLanguage(Language.PtBr);
            string ptBr = Randomic.Address.City();
            Assert.AreEqual("Cuiabá", ptBr);

            // EnUs (not available)
            Randomic.SetLanguage(Language.EnUs);
            string enUs = Randomic.Address.City();
            Assert.AreEqual("Des Moines", enUs);
        }
    }
}
