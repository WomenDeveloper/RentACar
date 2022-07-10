using System;
using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using Entity.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, NorthwindContext>,IRentalDal
    {
        
    }
}

