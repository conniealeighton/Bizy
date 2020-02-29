using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public class UserReport : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public ApplicationUser ComplaintIssuer { get; set; }

        public ApplicationUser Moderator { get; set; }

        public string UserComplaint { get; set; }

        public string ModeratorComment { get; set; }
        
        public bool StrikeIssued { get; set; }      

    }
}
