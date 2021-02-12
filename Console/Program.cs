using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //GetByBrandId(carManager);

            //GetCarsByColorId(carManager);

            //brandManager.Add(new Brand { BrandName = "SKODA" });

            //BrandGetAll(brandManager);

            //carManager.Delete(new Car { CarId = 6 });

            //carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 700, ModelYear = 2020, Description = "520i" });

            //brandManager.Delete(new Brand { BrandName = "OPEL" });

            //colorManager.Update(new Color { Id = 3, ColorName = "KIRMIZI" });

            //carManager.Update(new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 520, ModelYear = 2019, Description = "C200D" });

            //CarGetAll(carManager);

            //GetCarDetails(carManager);

        }

        private static void GetCarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    System.Console.WriteLine(item.BrandName + " " + item.Description + " " + item.ColorName + " " + item.DailyPrice);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            
        }

        private static void CarGetAll(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car2 in result.Data)
                {
                    System.Console.WriteLine(car2.Description + " " + car2.DailyPrice);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    System.Console.WriteLine(brand.BrandName);
                }
            }
            
        }

        private static void GetCarsByColorId(CarManager carManager)
        {
            var result = carManager.GetCarsByColorId(1);
            System.Console.WriteLine("ColorId si 1 olan araçlar");
            if (result.Success)
            {
                foreach (var car1 in result.Data)
                {
                    System.Console.WriteLine(car1.Description + car1.ModelYear);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            
        }

        private static void GetByBrandId(CarManager carManager)
        {
            var result = carManager.GetCarsByBrandId(2);
            System.Console.WriteLine("BrandId si 2 olan araçlar");
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ModelYear);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            
        }
    }
}
