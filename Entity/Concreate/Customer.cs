using System;
using Core.Entities;

namespace Entity.Concreate
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public int UserId{ get; set; }
        public string CompanyName { get; set; }
    }
}

