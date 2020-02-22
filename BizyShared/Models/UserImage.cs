using System;
using System.Collections.Generic;
using System.Text;

namespace BizyShared.Models
{
    public class UserImage : Model
    {
        public virtual User User { get; set; }

        public string Url { get; set; }

        public int Order { get; set; }
    }
}
