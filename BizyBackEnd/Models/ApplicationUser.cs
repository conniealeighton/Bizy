﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Threading.Tasks;

namespace BizyBackEnd.Models
{
    public enum Genders
    {
        Male,
        Female,
        NonBinary
    }

    public class ApplicationUser : IdentityUser
    {
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

        public DbGeography LastLocation { get; set; }
    }
}
