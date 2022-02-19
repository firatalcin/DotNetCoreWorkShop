using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
                _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if(car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarIsInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            if(car.CarId == 0)
            {
                return new ErrorResult(Messages.CarIsInvalid);
            }
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);

        }

        public IDataResult<List<Car>> GetAll()
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed) ;
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), Messages.CarListed) ;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(), Messages.CarListed);
        }

        public IResult Update(Car car)
        {
            if (car.ModelYear < 2000)
            {
                return new ErrorResult(Messages.CarIsInvalid);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
