using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public EfCarDal()
        {
        }

        public void Add(Car entity)
        {    //IDisposable pattern implementation of c#
            using (NorthwindContext context= new NorthwindContext())
            {
                var addedEnitity = context.Entry(entity);
                addedEnitity.State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public void Delete(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            };
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Car>().SingleOrDefault();
            };
        }

        public void Update(Car entity)
        {
            using( NorthwindContext context = new NorthwindContext())
            {
                var updatedEnitiy = context.Entry(entity);
                updatedEnitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

