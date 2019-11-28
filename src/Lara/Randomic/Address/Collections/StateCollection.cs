using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class StateCollection
    {
        /// <summary>
        ///  Returns a list of States with NAme, Abbreviation and Capital. Example: "Florida, FL, Tallahassee".
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<IRandomState> GetCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetEnUs(),
                Language.PtBr => GetPtBr(),
                _ => GetEnUs(),
            };
        }

        /// <summary>
        /// Returns a list of Cities in EnUs.
        /// </summary>
        private List<IRandomState> GetEnUs()
        {
            return new List<IRandomState>
            {
                new RandonState ("Alabama", "AL", "Montgomery"),
                new RandonState ("Alaska", "AK", "Juneau"),
                new RandonState ("Arizona", "AZ", "Phoenix"),
                new RandonState ("Arkansas", "AR", "Little Rock"),
                new RandonState ("California", "CA", "Sacramento"),
                new RandonState ("Colorado", "CO", "Denver"),
                new RandonState ("Connecticut", "CT", "Hartford"),
                new RandonState ("Delaware", "DE", "Dover"),
                new RandonState ("Florida", "FL", "Tallahassee"),
                new RandonState ("Georgia", "GA", "Atlanta"),
                new RandonState ("Hawaii", "HI", "Honolulu"),
                new RandonState ("Idaho", "ID", "Boise"),
                new RandonState ("Illinois", "IL", "Springfield"),
                new RandonState ("Indiana", "IN", "Indianapolis"),
                new RandonState ("Iowa", "IA", "Des Moines"),
                new RandonState ("Kansas", "KS", "Topeka"),
                new RandonState ("Kentucky[E]", "KY", "Frankfort"),
                new RandonState ("Louisiana", "LA", "Baton Rouge"),
                new RandonState ("Maine", "ME", "Augusta"),
                new RandonState ("Maryland", "MD", "Annapolis"),
                new RandonState ("Massachusetts[E]", "MA", "Boston"),
                new RandonState ("Michigan", "MI", "Lansing"),
                new RandonState ("Minnesota", "MN", "St. Paul"),
                new RandonState ("Mississippi", "MS", "Jackson"),
                new RandonState ("Missouri", "MO", "Jefferson City"),
                new RandonState ("Montana", "MT", "Helena"),
                new RandonState ("Nebraska", "NE", "Lincoln"),
                new RandonState ("Nevada", "NV", "Carson City"),
                new RandonState ("New Hampshire", "NH", "Concord"),
                new RandonState ("New Jersey", "NJ", "Trenton"),
                new RandonState ("New Mexico", "NM", "Santa Fe"),
                new RandonState ("New York", "NY", "Albany"),
                new RandonState ("North Carolina", "NC", "Raleigh"),
                new RandonState ("North Dakota", "ND", "Bismarck"),
                new RandonState ("Ohio", "OH", "Columbus"),
                new RandonState ("Oklahoma", "OK", "Oklahoma City"),
                new RandonState ("Oregon", "OR", "Salem"),
                new RandonState ("Pennsylvania[E]", "PA", "Harrisburg"),
                new RandonState ("Rhode Island[F]", "RI", "Providence"),
                new RandonState ("South Carolina", "SC", "Columbia"),
                new RandonState ("South Dakota", "SD", "Pierre"),
                new RandonState ("Tennessee", "TN", "Nashville"),
                new RandonState ("Texas", "TX", "Austin"),
                new RandonState ("Utah", "UT", "Salt Lake City"),
                new RandonState ("Vermont", "VT", "Montpelier"),
                new RandonState ("Virginia[E]", "VA", "Richmond"),
                new RandonState ("Washington", "WA", "Olympia"),
                new RandonState ("West Virginia", "WV", "Charleston"),
                new RandonState ("Wisconsin", "WI", "Madison"),
                new RandonState ("Wyoming", "WY", "Cheyenne")
            };
        }

        /// <summary>
        /// Returns a list of Cities in PtBr.
        /// </summary>
        private List<IRandomState> GetPtBr()
        {
            return new List<IRandomState>
            {
                new RandonState ("Acre", "AC", "Rio Branco"),
                new RandonState ("Alagoas", "AL", "Maceió"),
                new RandonState ("Amapá", "AP", "Macapá"),
                new RandonState ("Amazonas", "AM", "Manaus"),
                new RandonState ("Bahia", "BA", "Salvador"),
                new RandonState ("Ceará", "CE", "Fortaleza"),
                new RandonState ("Espírito Santo", "ES", "Vitória"),
                new RandonState ("Goiás", "GO", "Goiânia"),
                new RandonState ("Maranhão", "MA", "São Luís"),
                new RandonState ("Mato Grosso", "MT", "Cuiabá"),
                new RandonState ("Mato Grosso do Sul", "MS", "Campo Grande"),
                new RandonState ("Minas Gerais", "MG", "Belo Horizonte"),
                new RandonState ("Pará", "PA", "Belém"),
                new RandonState ("Paraíba", "PB", "João Pessoa"),
                new RandonState ("Paraná", "PR", "Curitiba"),
                new RandonState ("Pernambuco", "PE", "Recife"),
                new RandonState ("Piauí", "PI", "Teresina"),
                new RandonState ("Rio de Janeiro", "RJ", "Rio de Janeiro"),
                new RandonState ("Rio Grande do Norte", "RN", "Natal"),
                new RandonState ("Rio Grande do Sul", "RS", "Porto Alegre"),
                new RandonState ("Rondônia", "RO", "Porto Velho"),
                new RandonState ("Roraima", "RR", "Boa Vista"),
                new RandonState ("Santa Catarina", "SC", "Florianópolis"),
                new RandonState ("São Paulo", "SP", "São Paulo"),
                new RandonState ("Sergipe", "SE", "Aracaju"),
                new RandonState ("Tocantins", "TO", "Palmas"),
                new RandonState ("Distrito Federal", "DF", "Brasília")
            };
        }
    }
}
