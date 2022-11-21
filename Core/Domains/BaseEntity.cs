using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domains
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
    }
}
