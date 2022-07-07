using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{ BrandId=1,BrandName="Hyundai"},
                new Brand{ BrandId=2,BrandName="Togg"},
                new Brand{ BrandId=3,BrandName="BMW"},
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand deleteToBrand = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(deleteToBrand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(b => b.BrandId == id);
        }

        public Brand GetById(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            Brand updateToBrand = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            updateToBrand.BrandName = brand.BrandName;
        }
    }
}

