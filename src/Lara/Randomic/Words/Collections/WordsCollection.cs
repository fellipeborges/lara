﻿using System.Collections.Generic;

namespace Lara.Randomizers
{
    internal class WordsCollection
    {
        /// <summary>
        ///  Returns a list of words based on the informed language.
        /// </summary>
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
        /// Returns a list of words in EnUs.
        /// </summary>
        private List<string> GetEnUs()
        {
            return new List<string>
            {
                "Activity",
                "Actor",
                "Advertising",
                "Advice",
                "Alcohol",
                "Analysis",
                "Anxiety",
                "Application",
                "Barbecue",
                "Bill",
                "Bonus",
                "Book",
                "Bottle",
                "Bus",
                "Car",
                "Chapter",
                "Chest",
                "Child",
                "Classroom",
                "Clothes",
                "Coke",
                "Complaint",
                "Computer",
                "Contribution",
                "Control",
                "Country",
                "Cube",
                "Dinner",
                "Direction",
                "Disease",
                "Ear",
                "Economics",
                "Estate",
                "Excel",
                "Family",
                "Father",
                "Food",
                "Growth",
                "Guittar",
                "Hair",
                "Hall",
                "Headset",
                "Heart",
                "Imagination",
                "Injury",
                "Insect",
                "Keyboard",
                "Keys",
                "Ladder",
                "Laptop",
                "Literature",
                "Love",
                "Lunch",
                "Man",
                "Meal",
                "Meaning",
                "Microwaves",
                "Mother",
                "Mouse",
                "Movie",
                "Network",
                "Outcome",
                "Oven",
                "Permission",
                "Phone",
                "Photo",
                "Potato",
                "Presence",
                "Problem",
                "Promotion",
                "Proposal",
                "Protection",
                "Reaction",
                "Recipe",
                "Refrigerator",
                "Republic",
                "Reputation",
                "Ring",
                "Sample",
                "Series",
                "Setting",
                "Skill",
                "Smartphone",
                "Soccer",
                "Soda",
                "Technology",
                "Tennis",
                "TV",
                "Union",
                "User",
                "Variation",
                "Version",
                "Virus",
                "Volume",
                "Warning",
                "Watch",
                "Wire",
                "Wireless",
                "Woman",
                "Youth"
            };
        }

        /// <summary>
        /// Returns a list of words in PtBr.
        /// </summary>
        private List<string> GetPtBr()
        {
            return new List<string>
            {
                "Álcool",
                "Almoço",
                "Amor",
                "Análise",
                "Anel",
                "Ansiedade",
                "Aplicação",
                "Atividade",
                "Ator",
                "Aviso",
                "Batata",
                "Boleto",
                "Bônus",
                "Cabelo",
                "Capítulo",
                "Carro",
                "Celular",
                "Chaves",
                "Churrasco",
                "Coca-cola",
                "Comida",
                "Complacente",
                "Computador",
                "Configuração",
                "Conselho",
                "Contribuição",
                "Controle",
                "Coração",
                "Crescimento",
                "Criança",
                "Cubo",
                "Direção",
                "Doença",
                "Economia",
                "Escada",
                "Estado",
                "Excel",
                "Exemplo",
                "Família",
                "Filme",
                "Fio",
                "Fone",
                "Forno",
                "Foto",
                "Futebol",
                "Garrafa",
                "Geladeira",
                "Habilidade",
                "Homem",
                "Imaginação",
                "Inseto",
                "Jantar",
                "Juventude",
                "Literatura",
                "Livro",
                "Machucado",
                "Mãe",
                "Microondas",
                "Mouse",
                "Mulher",
                "Notebook",
                "Ônibus",
                "Orelha",
                "Pai",
                "País",
                "Peito",
                "Permissão",
                "Presença",
                "Problema",
                "Promoção",
                "Proposta",
                "Proteção",
                "Publicidade",
                "Reação",
                "Receita",
                "Recepção",
                "Rede",
                "Refeição",
                "Refrigerante",
                "Relógio",
                "República",
                "Reputação",
                "Roupas",
                "Saída",
                "Sala de aula",
                "Sem fio",
                "Série",
                "Significado",
                "Teclado",
                "Tecnologia",
                "Telefone",
                "Tênis",
                "TV",
                "União",
                "Usuário",
                "Variação",
                "Versão",
                "Violão",
                "Vírus",
                "Volume"
            };
        }
    }
}
