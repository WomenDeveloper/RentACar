using System;
using System.Collections.Generic;
using Entities.Concreate;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorıd);
        List<CarDetailDto> GetCarDetails();
    }
}

