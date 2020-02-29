using System;
using System.Collections.Generic;
using System.Text;
using BizyServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BizyServer.Data
{
    public class BizyDbContext : IdentityDbContext
    {
        public BizyDbContext(DbContextOptions<BizyDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationUserMatch> ApplicationUserMatches { get; set; }
        public DbSet<UserReport> UserReports { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<AvailableDate> AvailableDates { get; set; }

    }
}
