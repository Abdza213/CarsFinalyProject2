using _Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Entities.Abstract
{
    public class Cars : IEntity
    {
        [Key]
        public int CarId { get; set; }

        public string BrandName { get; set; }

        public string ColorName { get; set; }

        public int ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }

    }
}
