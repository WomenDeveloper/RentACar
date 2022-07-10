﻿using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concreate
{
    public class Car : IEntity
    {
        public int  CarId { get; set; }
        public int  BrandId { get; set; }
        public int  ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string  CarName { get; set; }
    }

}

