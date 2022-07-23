using System;
using Core.Utilities.Results;

namespace Core.Business
{
    public class BusinessRules
    {
        public BusinessRules()
        {
        }
        public  static IResult Run(params IResult[] logics)
        {
            foreach(var logic in logics)
            {
                if (!logic.Success) return logic;
            }
            return null;
        }
    }
}

