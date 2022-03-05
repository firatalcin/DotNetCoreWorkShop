using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentDal = rentalDal; 
        }
        public IResult Add(Rental rental)
        {
           _rentDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(x => x.CustomerId == customerId), Messages.CustomerListed);
        }

        public IResult Update(Rental rental)
        {
            _rentDal.Update(rental);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
