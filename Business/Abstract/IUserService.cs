﻿using System;
using System.Collections.Generic;
using Core.Entities.Concreate;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entity.Concreate;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);

        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}

