using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concreate;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {


        List<CarDetailDto> GetCarDetaills();
    }
}

