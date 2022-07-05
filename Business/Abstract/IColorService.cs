using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
    }
}

