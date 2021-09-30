using _Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Entities.Abstract
{
    public class Brands : IEntity
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }

    }
}
