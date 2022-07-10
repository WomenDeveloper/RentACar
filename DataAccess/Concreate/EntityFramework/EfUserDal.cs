using System;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entity.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        
    }
}

