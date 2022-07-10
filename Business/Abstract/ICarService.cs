using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concreate;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorıd);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}

