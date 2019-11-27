using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class AddressTypeCollection
    {
        /// <summary>
        ///  Returns a list of Address Types. Exeamples: "Street", "Avenue", etc..
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<string> GetTypeCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetTypeEnUs(),
                Language.PtBr => GetTypePtBr(),
                _ => GetTypeEnUs(),
            };
        }

        /// <summary>
        ///  Returns a list of abbreviated Address Types. Exeamples: "St.", "Av.", etc..
        /// </summary>
        /// <param name="language">The language to consider when returning the list.</param>
        internal List<string> GetAbbreviatedTypeCollection(Language language)
        {
            return language switch
            {
                Language.EnUs => GetAbbreviatedTypeEnUs(),
                Language.PtBr => GetAbbreviatedTypePtBr(),
                _ => GetAbbreviatedTypeEnUs(),
            };
        }

        /// <summary>
        /// Returns a list of address types in EnUs.
        /// </summary>
        private List<string> GetTypeEnUs()
        {
            return new List<string>
            {
                "Road",
                "Way",
                "Street",
                "Avenue",
                "Boulevard",
                "Lane",
                "Drive",
                "Terrace",
                "Place",
                "Plaza",
                "Square",
            };
        }

        /// <summary>
        /// Returns a list of address types in PtBr.
        /// </summary>
        private List<string> GetTypePtBr()
        {
            return new List<string>
            {
                "Acesso",
                "Alameda",
                "Avenida",
                "Balneário",
                "Beco",
                "Bosque",
                "Canal",
                "Complexo Viário",
                "Campo",
                "Estrada",
                "Ladeira",
                "Pátio",
                "Praça",
                "Parque",
                "Ponte",
                "Quadra",
                "Rua",
                "Rodovia",
                "Retorno",
                "Travessa",
                "Viaduto",
                "Viela"
            };
        }

        /// <summary>
        /// Returns a list of abbreviated address types in EnUs.
        /// </summary>
        private List<string> GetAbbreviatedTypeEnUs()
        {
            return new List<string>
            {
                "Rd.",
                "W.",
                "St.",
                "Av.",
                "Blvd.",
                "Ln.",
                "Drv.",
                "Ter.",
                "Plc.",
                "Plz.",
                "Sqr.",
            };
        }

        /// <summary>
        /// Returns a list of abbreviated address types in PtBr.
        /// </summary>
        private List<string> GetAbbreviatedTypePtBr()
        {
            return new List<string>
            {
                "Ac.",
                "Al.",
                "Av.",
                "Bal.",
                "Bc.",
                "Bq.",
                "Cnl.",
                "Compl. V.",
                "Cpo.",
                "Est.",
                "Lad.",
                "Pt.",
                "Prc.",
                "Pq.",
                "Pte.",
                "Qd.",
                "R.",
                "Rd.",
                "Ret.",
                "Trav.",
                "Viad.",
                "Vi."
            };
        }
    }
}
