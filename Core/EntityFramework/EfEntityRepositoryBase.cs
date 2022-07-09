using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity: class,IEntity, new()
        where TContext: DbContext, new()
    {
        public EfEntityRepositoryBase()
        {
        }

        public void Add(TEntity entity)
        {    //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEnitity = context.Entry(entity);
                addedEnitity.State = EntityState.Added;
                context.SaveChanges();
            };
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            };
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            };
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault();
            };
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEnitiy = context.Entry(entity);
                updatedEnitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

