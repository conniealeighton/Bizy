using System;
using System.Collections.Generic;
using System.Text;

namespace BizyBackEnd.Models
{
    public class UserImage : Model
    {
        public virtual ApplicationUser User { get; set; }

        public string Url { get; set; }

        public int Order { get; set; }
    }
}
