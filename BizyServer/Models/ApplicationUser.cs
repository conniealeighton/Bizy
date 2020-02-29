using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public enum Genders
    {
        Male,
        Female,
        NonBinary
    }

    public class ApplicationUser : IdentityUser<Guid>, IModel
    {

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

        public virtual ICollection<ApplicationUserMatch> ApplicationUserMatches { get; set; }

        public int Strikes { get; set; }

       // public DbGeography LastLocation { get; set; }

        public bool IsAdmin { get; set; }

        public virtual ICollection<AvailableDate> AvailableDates { get; set; }
    }
}
