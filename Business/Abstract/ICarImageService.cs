using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concreate;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int id);

        IResult Add(CarImage carImage , IFormFile file);
        IResult Update(CarImage carImage , IFormFile file);
        IResult Delete(CarImage carImage);
    }
}

