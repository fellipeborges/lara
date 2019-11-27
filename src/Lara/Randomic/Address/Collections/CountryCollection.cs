﻿using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class CountryCollection
    {
        /// <summary>
        ///  Returns a list of Countries. Exeamples: "Brazil", "Argentina", etc..
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<string> GetCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetEnUs(),
                Language.PtBr => GetPtBr(),
                _ => GetEnUs(),
            };
        }

        /// <summary>
        /// Returns a list of countries in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                "Albania",
                "Algeria",
                "Andorra",
                "Angola",
                "Antigua and Barbuda",
                "Argentina",
                "Armenia",
                "Australia",
                "Austria",
                "Azerbaijan",
                "Bahamas",
                "Bahrain",
                "Bangladesh",
                "Barbados",
                "Belarus",
                "Belgium",
                "Belize",
                "Benin",
                "Bhutan",
                "Bolivia",
                "Bosnia and Herzegovina",
                "Botswana",
                "Brazil",
                "Brunei",
                "Bulgaria",
                "Burkina Faso",
                "Burundi",
                "Côte d'Ivoire",
                "Cabo Verde",
                "Cambodia",
                "Cameroon",
                "Canada",
                "Central African Republic",
                "Chad",
                "Chile",
                "China",
                "Colombia",
                "Comoros",
                "Congo (Congo-Brazzaville)",
                "Costa Rica",
                "Croatia",
                "Cuba",
                "Cyprus",
                "Czechia (Czech Republic)",
                "Democratic Republic of the Congo",
                "Denmark",
                "Djibouti",
                "Dominica",
                "Dominican Republic",
                "Ecuador",
                "Egypt",
                "El Salvador",
                "Equatorial Guinea",
                "Eritrea",
                "Estonia",
                "Ethiopia",
                "Fiji",
                "Finland",
                "France",
                "Gabon",
                "Gambia",
                "Georgia",
                "Germany",
                "Ghana",
                "Greece",
                "Grenada",
                "Guatemala",
                "Guinea",
                "Guinea-Bissau",
                "Guyana",
                "Haiti",
                "Holy See",
                "Honduras",
                "Hungary",
                "Iceland",
                "India",
                "Indonesia",
                "Iran",
                "Iraq",
                "Ireland",
                "Israel",
                "Italy",
                "Jamaica",
                "Japan",
                "Jordan",
                "Kazakhstan",
                "Kenya",
                "Kiribati",
                "Kuwait",
                "Kyrgyzstan",
                "Laos",
                "Latvia",
                "Lebanon",
                "Lesotho",
                "Liberia",
                "Libya",
                "Liechtenstein",
                "Lithuania",
                "Luxembourg",
                "Madagascar",
                "Malawi",
                "Malaysia",
                "Maldives",
                "Mali",
                "Malta",
                "Marshall Islands",
                "Mauritania",
                "Mauritius",
                "Mexico",
                "Micronesia",
                "Moldova",
                "Monaco",
                "Mongolia",
                "Montenegro",
                "Morocco",
                "Mozambique",
                "Myanmar (formerly Burma)",
                "Namibia",
                "Nauru",
                "Nepal",
                "Netherlands",
                "New Zealand",
                "Nicaragua",
                "Niger",
                "Nigeria",
                "North Korea",
                "North Macedonia",
                "Norway",
                "Oman",
                "Pakistan",
                "Palau",
                "Palestine State",
                "Panama",
                "Papua New Guinea",
                "Paraguay",
                "Peru",
                "Philippines",
                "Poland",
                "Portugal",
                "Qatar",
                "Romania",
                "Russia",
                "Rwanda",
                "Saint Kitts and Nevis",
                "Saint Lucia",
                "Saint Vincent and the Grenadines",
                "Samoa",
                "San Marino",
                "Sao Tome and Principe",
                "Saudi Arabia",
                "Senegal",
                "Serbia",
                "Seychelles",
                "Sierra Leone",
                "Singapore",
                "Slovakia",
                "Slovenia",
                "Solomon Islands",
                "Somalia",
                "South Africa",
                "South Korea",
                "South Sudan",
                "Spain",
                "Sri Lanka",
                "Sudan",
                "Suriname",
                "Sweden",
                "Switzerland",
                "Syria",
                "Tajikistan",
                "Tanzania",
                "Thailand",
                "Timor-Leste",
                "Togo",
                "Tonga",
                "Trinidad and Tobago",
                "Tunisia",
                "Turkey",
                "Turkmenistan",
                "Tuvalu",
                "Uganda",
                "Ukraine",
                "United Arab Emirates",
                "United Kingdom",
                "United States of America",
                "Uruguay",
                "Uzbekistan",
                "Vanuatu",
                "Venezuela",
                "Vietnam",
                "Yemen",
                "Zambia",
                "Zimbabwe"
            };
        }

        /// <summary>
        /// Returns a list of names in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Afeganistão",
                "África do Sul",
                "Akrotiri",
                "Albânia",
                "Alemanha",
                "Andorra",
                "Angola",
                "Anguila",
                "Antárctida",
                "Antígua e Barbuda",
                "Arábia Saudita",
                "Arctic Ocean",
                "Argélia",
                "Argentina",
                "Arménia",
                "Aruba",
                "Ashmore and Cartier Islands",
                "Atlantic Ocean",
                "Austrália",
                "Áustria",
                "Azerbaijão",
                "Baamas",
                "Bangladeche",
                "Barbados",
                "Barém",
                "Bélgica",
                "Belize",
                "Benim",
                "Bermudas",
                "Bielorrússia",
                "Birmânia",
                "Bolívia",
                "Bósnia e Herzegovina",
                "Botsuana",
                "Brasil",
                "Brunei",
                "Bulgária",
                "Burquina Faso",
                "Burúndi",
                "Butão",
                "Cabo Verde",
                "Camarões",
                "Camboja",
                "Canadá",
                "Catar",
                "Cazaquistão",
                "Chade",
                "Chile",
                "China",
                "Chipre",
                "Clipperton Island",
                "Colômbia",
                "Comores",
                "Congo-Brazzaville",
                "Congo-Kinshasa",
                "Coral Sea Islands",
                "Coreia do Norte",
                "Coreia do Sul",
                "Costa do Marfim",
                "Costa Rica",
                "Croácia",
                "Cuba",
                "Curacao",
                "Dinamarca",
                "Domínica",
                "Egipto",
                "Emiratos Árabes Unidos",
                "Equador",
                "Eritreia",
                "Eslováquia",
                "Eslovénia",
                "Espanha",
                "Estados Unidos",
                "Estónia",
                "Etiópia",
                "Faroé",
                "Fiji",
                "Filipinas",
                "Finlândia",
                "França",
                "Gabão",
                "Gâmbia",
                "Gana",
                "Gaza Strip",
                "Geórgia",
                "Geórgia do Sul e Sandwich do Sul",
                "Gibraltar",
                "Granada",
                "Grécia",
                "Gronelândia",
                "Guame",
                "Guatemala",
                "Guernsey",
                "Guiana",
                "Guiné",
                "Guiné Equatorial",
                "Guiné-Bissau",
                "Haiti",
                "Honduras",
                "Hong Kong",
                "Hungria",
                "Iémen",
                "Ilha Bouvet",
                "Ilha do Natal",
                "Ilha Norfolk",
                "Ilhas Caimão",
                "Ilhas Cook",
                "Ilhas dos Cocos",
                "Ilhas Falkland",
                "Ilhas Heard e McDonald",
                "Ilhas Marshall",
                "Ilhas Salomão",
                "Ilhas Turcas e Caicos",
                "Ilhas Virgens Americanas",
                "Ilhas Virgens Britânicas",
                "Índia",
                "Indian Ocean",
                "Indonésia",
                "Irão",
                "Iraque",
                "Irlanda",
                "Islândia",
                "Israel",
                "Itália",
                "Jamaica",
                "Jan Mayen",
                "Japão",
                "Jersey",
                "Jibuti",
                "Jordânia",
                "Kosovo",
                "Kuwait",
                "Laos",
                "Lesoto",
                "Letónia",
                "Líbano",
                "Libéria",
                "Líbia",
                "Listenstaine",
                "Lituânia",
                "Luxemburgo",
                "Macau",
                "Macedónia",
                "Madagáscar",
                "Malásia",
                "Malávi",
                "Maldivas",
                "Mali",
                "Malta",
                "Man, Isle of",
                "Marianas do Norte",
                "Marrocos",
                "Maurícia",
                "Mauritânia",
                "México",
                "Micronésia",
                "Moçambique",
                "Moldávia",
                "Mónaco",
                "Mongólia",
                "Monserrate",
                "Montenegro",
                "Mundo",
                "Namíbia",
                "Nauru",
                "Navassa Island",
                "Nepal",
                "Nicarágua",
                "Níger",
                "Nigéria",
                "Niue",
                "Noruega",
                "Nova Caledónia",
                "Nova Zelândia",
                "Omã",
                "Pacific Ocean",
                "Países Baixos",
                "Palau",
                "Panamá",
                "Papua-Nova Guiné",
                "Paquistão",
                "Paracel Islands",
                "Paraguai",
                "Peru",
                "Pitcairn",
                "Polinésia Francesa",
                "Polónia",
                "Porto Rico",
                "Portugal",
                "Quénia",
                "Quirguizistão",
                "Quiribáti",
                "Reino Unido",
                "República Centro-Africana",
                "República Checa",
                "República Dominicana",
                "Roménia",
                "Ruanda",
                "Rússia",
                "Salvador",
                "Samoa",
                "Samoa Americana",
                "Santa Helena",
                "Santa Lúcia",
                "São Bartolomeu",
                "São Cristóvão e Neves",
                "São Marinho",
                "São Martinho",
                "São Pedro e Miquelon",
                "São Tomé e Príncipe",
                "São Vicente e Granadinas",
                "Sara Ocidental",
                "Seicheles",
                "Senegal",
                "Serra Leoa",
                "Sérvia",
                "Singapura",
                "Sint Maarten",
                "Síria",
                "Somália",
                "Southern Ocean",
                "Spratly Islands",
                "Sri Lanca",
                "Suazilândia",
                "Sudão",
                "Sudão do Sul",
                "Suécia",
                "Suíça",
                "Suriname",
                "Svalbard e Jan Mayen",
                "Tailândia",
                "Taiwan",
                "Tajiquistão",
                "Tanzânia",
                "Timor Leste",
                "Togo",
                "Tokelau",
                "Tonga",
                "Trindade e Tobago",
                "Tunísia",
                "Turquemenistão",
                "Turquia",
                "Tuvalu",
                "Ucrânia",
                "Uganda",
                "União Europeia",
                "Uruguai",
                "Usbequistão",
                "Vanuatu",
                "Vaticano",
                "Venezuela",
                "Vietname",
                "Wake Island",
                "Wallis e Futuna",
                "West Bank",
                "Zâmbia",
                "Zimbabué"
            };
        }
    }
}
