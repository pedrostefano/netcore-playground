using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class BaseEntity
    {
        [Key]
        public virtual long ID { get; set; }
    }
}


