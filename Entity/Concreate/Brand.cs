using System;
using Core.Entities;

namespace Entities.Concreate
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}

