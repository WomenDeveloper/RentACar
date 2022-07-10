using System;
using Core.DataAccess;
using Entity.Concreate;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}

