using BizyShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public class UserReport : IModel
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public User ComplaintIssuer { get; set; }

        public User Moderator { get; set; }

        public string UserComplaint { get; set; }

        public string ModeratorComment { get; set; }
        
        public bool StrikeIssued { get; set; }      

    }
}
