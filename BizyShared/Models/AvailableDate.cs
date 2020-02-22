using BizyShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizyServer.Models
{
    public class AvailableDate : IModel
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public User User { get; set; }
     
        public DateTime DateAvailable { get; set; }

    }
}
