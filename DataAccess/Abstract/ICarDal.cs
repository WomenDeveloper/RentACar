using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<Car> GetAllByBrand(int brandId);
        List<Car> GetAllByColor(int colorId);

    }
}

