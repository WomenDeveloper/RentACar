using System;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entity.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext> , ICustomerDal
    {
        
    }
}

