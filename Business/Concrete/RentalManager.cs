﻿using Business.Abstract;
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

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorResult("Hata");
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
            var result = _rentalDal.GetRentalDetails();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<RentalDetailDto>>("Kirada Bulunan Araç Yok");
            }
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Güncellendi");
        }
    }
}
