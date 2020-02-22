using System;
using System.Collections.Generic;
using System.Text;

namespace BizyShared.Models
{
    public class Match
    {
        public IEnumerable<User> Couple { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<Message> Messages { get; set; }
    }
}
