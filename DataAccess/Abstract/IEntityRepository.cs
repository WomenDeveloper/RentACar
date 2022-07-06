using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetById(Expression<Func<T,bool>> filter);
        void Add(T T);
        void Delete(T T);
        void Update(T T);

    }
}

