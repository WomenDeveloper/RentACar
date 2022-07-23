using System;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entity.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, NorthwindContext> , ICarImageDal
    {

    }
}

