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
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
                //Console.WriteLine("Araç Kaydedildi");
            }
            return new ErrorResult(Messages.CarError);
            //Console.WriteLine("Lütfen Girdiğiniz Bilgileri Kontrol Edin");

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
            //Console.WriteLine("Araç Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Araçlar");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CarError);
                //Console.WriteLine("Lütfen Girdiğiniz Bilgileri Kontrol Edin");
            }
        }
    }
}
