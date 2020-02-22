using System;
using System.Collections.Generic;
using System.Text;

namespace BizyBackEnd.Models
{
    public class Like
    {
        public ApplicationUser Liker { get; set; }

        public ApplicationUser Liked { get; set; }
    }
}
