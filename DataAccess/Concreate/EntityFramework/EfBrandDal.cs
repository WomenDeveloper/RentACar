using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>,IBrandDal
    {
        public EfBrandDal()
        {
        }

        
    }
}

