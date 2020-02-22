using System;
using System.Collections.Generic;
using System.Text;

namespace BizyBackEnd.Models
{
    public class Message
    {
        public virtual ICollection<ApplicationUser> Match { get; set; }

        public ApplicationUser Sender { get; set; }

        public string Content { get; set; }

        public bool IsReceived { get; set; }

        public bool IsRead { get; set; }
    }
}
