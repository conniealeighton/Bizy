using System;
using System.Collections.Generic;
using System.Text;

namespace BizyShared.Models
{
    public class Like
    {
        public User Liker { get; set; }

        public User Liked { get; set; }
    }
}
