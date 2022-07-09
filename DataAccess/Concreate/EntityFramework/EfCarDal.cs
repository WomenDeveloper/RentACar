using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>,ICarDal
    {
        public EfCarDal()
        {
        }

        public List<CarDetailDto> GetCarDetaills()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarName =c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice= c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}

