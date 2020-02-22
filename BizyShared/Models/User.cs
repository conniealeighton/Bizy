﻿using System;
using System.Collections.Generic;

namespace BizyShared.Models
{
    public enum Genders
    {
        Male,
        Female,
        NonBinary
    }

    public class User : Model
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public virtual IEnumerable<UserImage> UserImages { get; set; }

        public string Biography { get; set; }

        public int MinAgePreference { get; set; }

        public int MaxAgePreference { get; set; }

        public Genders GenderIdentity { get; set; }
        
        public Genders SexualPreference { get; set; }

        public int MatchRadius { get; set; }

        public virtual IEnumerable<Match> Matches { get; set; }

        public int Strikes { get; set; }
    }
}
