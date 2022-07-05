﻿using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAllByBrand(int brandId);
        List<Car> GetAllByColor(int colorId);


    }
}

