﻿using System;

namespace Lara.Randomizers
{
    internal class RandomAddress : IRandomAddress
    {
        private readonly Language Language;

        public RandomAddress(Language language)
        {
            Language = language;
        }

        public string Country()
        {
            var collection = new CountryCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string Type()
        {
            var collection = new AddressTypeCollection().GetTypeCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string TypeAbbreviated()
        {
            var collection = new AddressTypeCollection().GetAbbreviatedTypeCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string Name()
        {
            string partA = Randomic.Among.Strings(
                Randomic.People.FirstName(),
                Randomic.People.LastName(),
                Randomic.Words.Planet(),
                Randomic.Words.ExoPlanet(),
                Randomic.Words.FamousPerson());

            string partB = Randomic.Among.Strings(
                Randomic.Words.ExoPlanet(),
                Randomic.Words.FamousPerson(),
                Randomic.People.LastName(),
                Randomic.People.FirstName(),
                Randomic.Words.Planet());

            string name = $"{partA} {partB}";
            return name;
        }

        public string Number()
        {
            // 20% of possibility of showing the letter
            bool mustShowLetter = Randomic.Basic.Boolean(0.2);
            string number = Randomic.Basic.Int(1, 99999).ToString();

            if (mustShowLetter)
            {
                string letter = Randomic.Basic.Text(1);
                number = $"{number} {letter}";
            }

            return number;
        }

        public string Complement()
        {
            var collection = new AddressComplementCollection().GetCollection(Language);
            string complement = Randomic.Among.Strings(collection);
            string number = Randomic.Basic.Int(1, 999).ToString();
            string letter = Randomic.Among.Strings("", Randomic.Basic.Text(1));
            string retValue = $"{complement} {number}{letter}";

            return retValue;
        }

        public string Complement(double probability)
        {
            string complement = Randomic.Basic.Boolean(probability) ?
                Complement() :
                "";

            return complement;
        }

        public string Neighborhood()
        {
            var collection = new AddressNeighborhoodCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public string City()
        {
            var collection = new CityCollection().GetCollection(Language);
            return Randomic.Among.Strings(collection);
        }

        public IRandomState State()
        {
            var collection = new StateCollection().GetCollection(Language);
            return Randomic.Among.Other<IRandomState>(collection);
        }

        public string ZipCode()
        {
            return Language switch
            {
                Language.EnUs => Randomic.Basic.Numeric(5),
                Language.PtBr => Randomic.Basic.Numeric(8),
                _ => Randomic.Basic.Numeric(5),
            };
        }

        public IRandomPhone Phone()
        {
            return Language switch
            {
                Language.EnUs => GetPhoneEnUs(),
                Language.PtBr => GetPhonePtBr(),
                _ => GetPhoneEnUs(),
            };
        }

        public string FullAddress()
        {
            return Language switch
            {
                Language.EnUs => GetFullAddressEnUs(),
                Language.PtBr => GetFullAddresstBr(),
                _ => GetFullAddressEnUs(),
            };
        }

        private IRandomPhone GetPhoneEnUs()
        {
            const string EUA_AREA_CODE = "+1";
            string areaCode = Randomic.Basic.Numeric(3);
            string number = Randomic.Basic.Numeric(7);
            string formatedNumber = $"{number.Substring(0, 3)}-{number.Substring(3, 4)}"; //nnn-nnnn

            return new RandomPhone
            {
                CountryCode = EUA_AREA_CODE,
                AreaCode = areaCode,
                Number = number,
                FormatedNumber = formatedNumber
            };
        }

        private IRandomPhone GetPhonePtBr()
        {
            const string BRAZIL_AREA_CODE = "+55";
            string areaCode = Randomic.Basic.Numeric(2);
            string number = Randomic.Basic.Numeric(8);
            string formatedNumber = $"{number.Substring(0, 4)}-{number.Substring(4, 4)}"; //nnnn-nnnn

            return new RandomPhone
            {
                CountryCode = BRAZIL_AREA_CODE,
                AreaCode = areaCode,
                Number = number,
                FormatedNumber = formatedNumber
            };
        }

        private string GetFullAddressEnUs()
        {
            // Format:
            // Number Name Type, City, State Abbreviation, Zip Code
            string address = $"{Number()} {Name()} {Type()}, {City()}, {State().Abbreviation}, {ZipCode()}";
            return address;
        }

        private string GetFullAddresstBr()
        {
            // Format:
            // Type Name, Number Complement, Neighborhood, City, State Abbreviation, Zip Code
            string optionalComplement = Complement(0.2);
            optionalComplement = !string.IsNullOrEmpty(optionalComplement) ? " " + optionalComplement : "";

            string address = $"{Type()} {Name()}, {Number()}{optionalComplement} - {Neighborhood()}, {City()} - {State().Abbreviation}, {ZipCode()}";

            return address;
        }

    }
}
