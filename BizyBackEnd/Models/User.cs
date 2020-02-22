using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Threading.Tasks;

namespace BizyBackEnd.Models
{
    public class User : BizyShared.Models.User
    {
        public DbGeography LastLocation { get; set; }
    }
}
