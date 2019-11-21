﻿using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class LastNameCollection
    {
        /// <summary>
        ///  Returns a list of last names based on the informed language
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<string> GetCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetEnUS(),
                Language.PtBr => GetPtBR(),
                _ => GetEnUS(),
            };
        }

        /// <summary>
        /// Returns a list of last names in EnUS.
        /// </summary>
        private List<string> GetEnUS()
        {
            return new List<string>
            {
                "Ashley",
                "Battaglia",
                "Bauer",
                "Bream",
                "Burke",
                "Byrd",
                "Canals-Barrera",
                "Canova",
                "Carter",
                "Chase",
                "Cooper",
                "Daniel",
                "Davis",
                "Depp",
                "Dunaway",
                "Edwards",
                "Esparza",
                "Fetchit",
                "Fox",
                "Gad",
                "Gant",
                "García",
                "Garza",
                "Gerald",
                "Gisondo",
                "Gorham",
                "Greene",
                "Gugino",
                "Hale",
                "Hammond",
                "Hecht",
                "Hendrix",
                "Hickland",
                "Hines",
                "Hunt",
                "Jackson",
                "Jackson",
                "Jenkins",
                "Justice",
                "Kasdan",
                "Kebbel",
                "Keener",
                "Labrava",
                "Matthews",
                "McQueen",
                "Meester",
                "Mixon",
                "Ratner",
                "Raymund",
                "Reid",
                "Rickards",
                "Rodriguez",
                "Rodriguez",
                "Root",
                "Ross",
                "Rourke",
                "Rudolph",
                "Sanchez",
                "Skipper",
                "Snipes",
                "Specter",
                "Thorne",
                "Vaughn",
                "Vereen",
                "Vila",
                "Whigham",
                "Alexander",
                "Billy",
                "Bentley",
                "Byrd-Nethery",
                "Canerday",
                "Carter",
                "Davis",
                "Duke",
                "Foster",
                "Gerard",
                "Goff",
                "Gracen",
                "Greenway",
                "Harris",
                "Harper",
                "Holt",
                "Hopper",
                "Hunnicutt",
                "Keener",
                "Lawrence",
                "Lofland",
                "Lucas",
                "Ray",
                "Murphy",
                "Powell",
                "Ragsdale",
                "Russom",
                "Steenburgen",
                "Tai",
                "Bob",
                "Turner",
                "Tyler",
                "Underwood",
                "Van"
            };
        }

        /// <summary>
        /// Returns a list of last names in PtBR.
        /// </summary>
        private List<string> GetPtBR()
        {
            return new List<string>
            {
                "Abrantes",
                "Alencar",
                "Alves",
                "Amaral",
                "Andrade",
                "Andral",
                "Anjos",
                "Aranha",
                "Assis",
                "Azulay",
                "Bandeira",
                "Barbosa",
                "Barreto",
                "Barros",
                "Batista",
                "Bebenco",
                "Bilac",
                "Bonner",
                "Borges",
                "Bozano",
                "Cabral",
                "Carolina",
                "Carvalho",
                "Carvana",
                "Cavalcanti",
                "Cerasi",
                "Clara",
                "Coelho",
                "Coimbra",
                "Coutinho",
                "Craveiro",
                "Dantas",
                "Dhalia",
                "Diegues",
                "Diniz",
                "Drummond",
                "Duarte",
                "Farias",
                "Ferreira",
                "Filho",
                "Fraga",
                "Franco",
                "Françozo",
                "Furtado",
                "Gênio",
                "Gomes",
                "Gonçalves",
                "Guerra",
                "Guimarães",
                "Gullar",
                "Huck",
                "Jabor",
                "Júnior",
                "Justino",
                "Largman",
                "Leal",
                "Lispector",
                "Lobato",
                "Machado",
                "Majczan",
                "Mangabeira",
                "Maria",
                "Marinho",
                "Matarazzo",
                "Mauro",
                "Medici",
                "Meireles",
                "Melo",
                "Menezes",
                "Moraes",
                "Morais",
                "Moreira",
                "Morelli",
                "Nascimento",
                "Neto",
                "Neves",
                "Oliveira",
                "Padilha",
                "Peixoto",
                "Pereira",
                "Porto",
                "Prado",
                "Ragnar",
                "Rezende",
                "Rocha",
                "Rodrigues",
                "Rustice",
                "Safra",
                "Santos",
                "Santos",
                "Saverin",
                "Soares",
                "Sobrino",
                "Souza",
                "Tai",
                "Taunay",
                "Thomas",
                "Vasconcelos",
                "Veríssimo",
                "Zito"
            };
        }
    }
}
