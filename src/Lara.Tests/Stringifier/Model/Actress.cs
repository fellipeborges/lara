﻿using System;
using System.Collections.Generic;

namespace StringifierTests
{
    public class Actress
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsDead { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public DateTime LatestIntervewDatetime { get; set; }

        public string[] Movies { get; set; }

        public List<string> Nominations { get; set; }

        public MainMediaType MainMediaType { get; set; }

        public PersonalInfo PersonalInfo { get; set; }
    }
}
