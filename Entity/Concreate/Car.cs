using System;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concreate
{
    public class Car : IEntity
    {
        public int  CarId { get; set; }
        public int  BrandId { get; set; }
        public int  ColorId { get; set; }
        public string ModelYear { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "")]
        public decimal DailyPrice { get; set; }
        [StringLength(2)]
        public string Description { get; set; }
    }
}

