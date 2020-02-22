using BizyShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class Match : IModel
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<User> Couple { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
