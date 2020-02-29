using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public class ApplicationUserMatch : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Key]

        public Match Match { get; set; }

        public string MatchId { get; set; }

        
    }
}
