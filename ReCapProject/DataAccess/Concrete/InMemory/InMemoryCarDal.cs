using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{ CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice = 500, Description = "Mercedes"},
                new Car{ CarId = 2, BrandId = 2, ColorId = 1, ModelYear = 2001, DailyPrice = 550, Description = "Honda"},
                new Car{ CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2002, DailyPrice = 1000, Description = "Tesla"},
                new Car{ CarId = 4, BrandId = 4, ColorId = 2, ModelYear = 2003, DailyPrice = 1500, Description = "BMW"},
                new Car{ CarId = 5, BrandId = 5, ColorId = 2, ModelYear = 2004, DailyPrice = 1600, Description = "Renault"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var CarToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
