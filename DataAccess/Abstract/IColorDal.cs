using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}

