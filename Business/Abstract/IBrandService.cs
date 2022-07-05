using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int id);
    }
}

