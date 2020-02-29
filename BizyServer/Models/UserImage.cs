using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class UserImage : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string Url { get; set; }

        public int Order { get; set; }
    }
}
