using BizyShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class Message : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<User> Match { get; set; }

        public User Sender { get; set; }

        public string Content { get; set; }

        public bool IsReceived { get; set; }

        public bool IsRead { get; set; }
    }
}
