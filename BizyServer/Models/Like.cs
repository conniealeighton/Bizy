using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class Like : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public ApplicationUser Liker { get; set; }

        public ApplicationUser Liked { get; set; }
    }
}
