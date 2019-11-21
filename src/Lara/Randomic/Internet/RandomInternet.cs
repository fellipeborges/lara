﻿namespace Lara.Randomizers
{
    internal class RandomInternet : IRandomInternet
    {
        public RandomInternet()
        {

        }

        public string Email()
        {
            string firstName = Randomic.People.FirstName();
            string lastName = Randomic.People.LastName();
            string optionalDot = Randomic.Basic.Boolean() ? "." : "";
            string optionalNumber = Randomic.Basic.Boolean() ? Randomic.Basic.Int(1000, 9999).ToString() : "";

            var domainCollections = new DomainCollection();
            string domain = Randomic.Among.Strings(domainCollections.GetEmailCollection());
            string topLevel = Randomic.Among.Strings(domainCollections.GetTopLevelCollection());
            string optionalCountryLevel = Randomic.Basic.Boolean() ? "." + Randomic.Among.Strings(domainCollections.GetCountryLevelCollection()) : "";

            string emailAddress = $"{firstName}{optionalDot}{lastName}{optionalNumber}@{domain}.{topLevel}{optionalCountryLevel}".ToLower();
            return emailAddress;
        }
    }
}
