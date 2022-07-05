using System;
using System.Collections.Generic;
using System.Linq;
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

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            Brand updateToBrand = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            updateToBrand.BrandName = brand.BrandName;
        }
    }
}

