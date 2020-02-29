using BizyShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizyServer.Models
{
    public class Like : IModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public User Liker { get; set; }

        public User Liked { get; set; }
    }
}
