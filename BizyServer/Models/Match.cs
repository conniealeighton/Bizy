using System;
using System.Collections.Generic;
using System.Text;

namespace BizyBackEnd.Models
{
    public class Match
    {
        public virtual ICollection<ApplicationUser> Couple { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
