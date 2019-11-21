using System;

namespace Lara.Randomizers
{
    internal class RandomPeople : IRandomPeople
    {
        private const int CHILD_YEARS_MIN = 0;
        private const int CHILD_YEARS_MAX = 12;

        private const int TEENAGER_YEARS_MIN = 13;
        private const int TEENAGER_YEARS_MAX = 19;

        private const int ADULT_YEARS_MIN = 20;
        private const int ADULT_YEARS_MAX = 59;

        private const int ELDER_YEARS_MIN = 60;
        private const int ELDER_YEARS_MAX = 100;

        private readonly Language Language;

        public RandomPeople(Language language)
        {
            Language = language;
        }

        public string FirstName()
        {
            var collection = new FirstNameCollection().GetCollection(Language);
            return Randomic.Among<string>(collection);
        }

        public string LastName()
        {
            var collection = new LastNameCollection().GetCollection(Language);
            return Randomic.Among<string>(collection);
        }

        public string FullName()
        {
            string firstName = FirstName();
            string lastName = LastName();
            return $"{firstName} {lastName}";
        }

        public string Prefix()
        {
            var collection = new PrefixCollection().GetCollection(Language);
            return Randomic.Among<string>(collection);
        }

        public int Age()
        {
            int age = Randomic.Basic.Int(0, 100);
            return age;
        }

        public int Age(AgeGroup ageGroup)
        {
            int age = ageGroup switch
            {
                AgeGroup.Child => Randomic.Basic.Int(CHILD_YEARS_MIN, CHILD_YEARS_MAX),
                AgeGroup.Teenager => Randomic.Basic.Int(TEENAGER_YEARS_MIN, TEENAGER_YEARS_MAX),
                AgeGroup.Adult => Randomic.Basic.Int(ADULT_YEARS_MIN, ADULT_YEARS_MAX),
                AgeGroup.Elder => Randomic.Basic.Int(ELDER_YEARS_MIN, ELDER_YEARS_MAX),
                _ => Age()
            };

            return age;
        }

        public DateTime BirthDate()
        {
            DateTime minDate = DateTime.Today.AddYears(-ELDER_YEARS_MAX);
            DateTime birthDate = Randomic.Basic.Date(minDate, DateTime.Today);
            return birthDate;
        }

        public DateTime BirthDate(AgeGroup ageGroup)
        {
            int minYears;
            int maxYears;

            switch (ageGroup)
            {
                case AgeGroup.Child:
                    minYears = CHILD_YEARS_MIN;
                    maxYears = CHILD_YEARS_MAX;
                    break;
                case AgeGroup.Teenager:
                    minYears = TEENAGER_YEARS_MIN;
                    maxYears = TEENAGER_YEARS_MAX;
                    break;
                case AgeGroup.Adult:
                    minYears = ADULT_YEARS_MIN;
                    maxYears = ADULT_YEARS_MAX;
                    break;
                case AgeGroup.Elder:
                    minYears = ELDER_YEARS_MIN;
                    maxYears = ELDER_YEARS_MAX;
                    break;
                default:
                    minYears = CHILD_YEARS_MIN;
                    maxYears = ELDER_YEARS_MAX;
                    break;
            }

            DateTime minDate = DateTime.Today.AddYears(-maxYears);
            DateTime maxDate = DateTime.Today.AddYears(-minYears);
            DateTime birthDate = Randomic.Basic.Date(minDate, maxDate);
            return birthDate;
        }
    }
}
