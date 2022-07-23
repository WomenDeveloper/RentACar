using System;
using Core.Entities;

namespace Entity.Concreate
{
    public class CarImage : IEntity
    {
        public int CarImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime ImageUploadDate { get; set; }

    }
}

