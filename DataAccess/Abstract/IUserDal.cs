using System;
using Core.DataAccess;
using Entity.Concreate;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}

