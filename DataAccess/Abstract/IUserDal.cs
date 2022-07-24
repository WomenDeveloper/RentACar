using System;
using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities.Concreate;
using Core.Entities.Concrete;
using Core.Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        public List<OperationClaim> GetClaims(User user);
    }
}

