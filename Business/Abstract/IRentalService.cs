using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entity.Concreate;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);

        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);

    }
}

