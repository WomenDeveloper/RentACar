using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concreate;
using Entity.DTOs;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1, BrandId=1, ColorId=1, DailyPrice=550, ModelYear="2012", Description="Mycar is the best"},
                new Car{ CarId=2, BrandId=1, ColorId=1, DailyPrice=1000, ModelYear="2023", Description="Togg"},
                new Car{ CarId=3, BrandId=2, ColorId=2, DailyPrice=250, ModelYear="2020", Description="BMW"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public Car GetById(int id)
        {
            return _cars.Single(c=>c.CarId == id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetaills()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}

