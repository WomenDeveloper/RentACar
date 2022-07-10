using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
    }
}

