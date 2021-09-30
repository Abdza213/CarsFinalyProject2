using _Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Entities.Abstract
{
    public class Colors : IEntity
    {
        [Key]
        public int ColorId { get; set; }

        public string ColorName { get; set; }
    }
}
