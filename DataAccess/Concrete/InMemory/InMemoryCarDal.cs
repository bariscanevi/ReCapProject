using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//        {
//            new Car{CarId=1, BrandId=2, ColorId=2, DailyPrice=300, ModelYear=2020, Description="VW GOLF"},
//            new Car{CarId=2, BrandId=1, ColorId=1, DailyPrice=500, ModelYear=2019, Description="MERCEDES C SERIES"},
//            new Car{CarId=3, BrandId=3, ColorId=4, DailyPrice=450, ModelYear=2017, Description="BMW 2 SERIES"},
//            new Car{CarId=4, BrandId=2, ColorId=3, DailyPrice=350, ModelYear=2021, Description="VW PASSAT"},
//        };
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(p => p.CarId == Id).ToList();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;

//            Console.WriteLine(carToUpdate.CarId + "Güncellendi");
//        }
//    }
//}
