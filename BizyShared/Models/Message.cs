using System;
using System.Collections.Generic;
using System.Text;

namespace BizyShared.Models
{
    public class Message
    {
        public ICollection<User> Match { get; set; }

        public User Sender { get; set; }

        public string Content { get; set; }

        public bool IsReceived { get; set; }

        public bool IsRead { get; set; }
    }
}
