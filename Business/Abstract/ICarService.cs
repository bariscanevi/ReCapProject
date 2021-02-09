﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int Id);
        List<Car> GetCarsByBrandId(int Id);
        List<CarDetailDto> GetCarDetails();

    }
}
