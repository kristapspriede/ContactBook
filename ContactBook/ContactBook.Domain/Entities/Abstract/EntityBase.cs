using System;
using System.ComponentModel.DataAnnotations;

namespace ContactBook.Domain.Entities.Abstract
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
