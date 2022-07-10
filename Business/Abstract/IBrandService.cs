using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
    }
}

