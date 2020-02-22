using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public class ApplicationUserMatch : IModel
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Match Match { get; set; }

        public string MatchId { get; set; }

        
    }
}
