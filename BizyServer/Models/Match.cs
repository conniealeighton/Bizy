using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class Match : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<ApplicationUserMatch> ApplicationUserMatches { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
