using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class AddressNeighborhoodCollection
    {
        /// <summary>
        ///  Returns a list of Address Neighborhoods. Examples: "Vila Formosa", "Tatuapé", etc..
        ///  Not avaialble in EnUs.
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
        /// Returns a list of Address Neighborhoods in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                ""
            };
        }

        /// <summary>
        /// Returns a list of Address Neighborhoods in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Água Rasa",
                "Alto da Mooca",
                "Aricanduva",
                "Bairro Vila São Francisco",
                "Baixo Augusta",
                "Bela Vista",
                "Bixiga‎",
                "Cambuci",
                "Capão do Embira",
                "Casa de Dona Yayá",
                "Catumbi",
                "Cerqueira César",
                "Chácara Belenzinho",
                "Chácara Mafalda",
                "Chácara Paraíso",
                "Chácara Seis de Outubro",
                "Chácara Tatuapé",
                "Cidade Bandeirantes",
                "Cidade Patriarca",
                "Cidade Universitária Armando de Salles Oliveira",
                "City Butantã",
                "Conjunto Habitacional José Bonifácio",
                "Fazenda do Carmo",
                "Ferreira",
                "Furnas",
                "Higienópolis",
                "Hipódromo",
                "Jardim Ademar",
                "Jardim Ademar de Barros",
                "Jardim Anália Franco",
                "Jardim Assunção",
                "Jardim Avelino",
                "Jardim Barreira Grande",
                "Jardim Bonfiglioli",
                "Jardim Catarina",
                "Jardim Caxingui",
                "Jardim Caxinguí",
                "Jardim Christie",
                "Jardim Cotching",
                "Jardim das Laranjeiras",
                "Jardim das Rosas",
                "Jardim Galli",
                "Jardim Guanabara",
                "Jardim Haddad",
                "Jardim Haia do Carrão",
                "Jardim Hercília",
                "Jardim Iara",
                "Jardim Itália",
                "Jardim Maringá",
                "Jardim Matarazzo",
                "Jardim Nice",
                "Jardim Pinheiros",
                "Jardim Rizzo",
                "Jardim Samara",
                "Jardim São Eduardo",
                "Jardim São Gilberto",
                "Jardim Silveira",
                "Jardim Suzana",
                "Jardim Tango",
                "Jardim Têxtil",
                "Jardim Triana",
                "Jardim Vila Formosa",
                "Lista dos bairros paulistanos por imigração",
                "Mooca",
                "Morro dos Ingleses",
                "Pacaembu",
                "Parque Cruzeiro do Sul",
                "Parque da Mooca",
                "Parque da Vila Prudente",
                "Parque Maria Luisa",
                "Parque Santa Madalena",
                "Pompeia",
                "Previdência",
                "Quinta da Paineira",
                "Rolinópolis",
                "Sítio da Figueira",
                "Vila Alpina",
                "Vila Antonieta",
                "Vila Antonina",
                "Vila Araci",
                "Vila Aricanduva",
                "Vila Bancária",
                "Vila Bela",
                "Vila Bertioga",
                "Vila Buarque",
                "Vila Califórnia",
                "Vila Celeste",
                "Vila Cláudia",
                "Vila Clotilde",
                "Vila Cruzeiro",
                "Vila Dalila",
                "Vila Diva",
                "Vila Embira",
                "Vila Eutália",
                "Vila Formosa",
                "Vila Gomes",
                "Vila Graciosa",
                "Vila Guarani",
                "Vila Guilhermina",
                "Vila Hamburguesa",
                "Vila Indiana",
                "Vila Invernada",
                "Vila Leme",
                "Vila Libanesa",
                "Vila Lúcia",
                "Vila Lúcia Elvira",
                "Vila Mafra",
                "Vila Matias",
                "Vila Matilde",
                "Vila Nova Iorque",
                "Vila Nova Savoia",
                "Vila Olinda",
                "Vila Oratório",
                "Vila Paulina",
                "Vila Pirajussara",
                "Vila Prudente",
                "Vila Regente Feijó",
                "Vila Remo",
                "Vila Rio Branco",
                "Vila Santa Clara",
                "Vila Sara",
                "Vila Talarico",
                "Vila Zelina"
            };
        }
    }
}
