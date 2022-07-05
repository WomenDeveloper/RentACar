using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        List<Brand> GetAll();
        Brand GetById(int id);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);
    }
}

