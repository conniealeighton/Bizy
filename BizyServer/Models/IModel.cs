using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BizyServer.Models
{
    public interface IModel
    {
        [Key]
        Guid Id {get; set;}

        [DataType(DataType.DateTime)]
        DateTime DateCreated { get; set; }

    }
}
