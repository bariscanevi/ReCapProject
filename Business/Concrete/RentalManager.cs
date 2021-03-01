using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfReturnDate(rental.CarId));
            if (result!=null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult("Araç Kiralandı");
            
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Kiralama İptal Edildi");
        }

        public IDataResult<List<Rental>> GetAllRental()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetById(int RentId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.Id == RentId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfReturnDate(rental.CarId));
            if (result!=null)
            {
                return result;
            }

            _rentalDal.Update(rental);
            return new SuccessResult("Güncellendi");
        }

        private IResult CheckIfReturnDate(int carId)
        {
            var result = _rentalDal.Get(r => r.CarId == carId && r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorResult("Hata");
            }
            return new SuccessResult();
        }
    }
}
