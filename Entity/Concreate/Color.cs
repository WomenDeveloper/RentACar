using System;
using Entities.Abstract;

namespace Entities.Concreate
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}

