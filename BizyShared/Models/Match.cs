using System;
using System.Collections.Generic;
using System.Text;

namespace BizyShared.Models
{
    public class Match
    {
        public ICollection<User> Couple { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
