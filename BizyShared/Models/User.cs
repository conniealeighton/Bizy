using BizyServer.Models;
using System;
using System.Collections.Generic;

namespace BizyShared.Models
{
    public enum Genders
    {
        Male,
        Female,
        NonBinary
    }

    public class User : IModel
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public virtual ICollection<UserImage> UserImages { get; set; }

        public string Biography { get; set; }

        public int MinAgePreference { get; set; }

        public int MaxAgePreference { get; set; }

        public Genders GenderIdentity { get; set; }

        public Genders SexualPreference { get; set; }

        public int MatchRadius { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        public int Strikes { get; set; }

        public bool IsAdmin { get; set; }

    }
}
