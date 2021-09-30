﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entites.Concrete
{
    public class Cars : IEntity
    {
        [Key]
        public int CarId { get; set; }

        public int ColorId { get; set; }

        public int BrandId { get; set; }

        public int ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }



    }
}

