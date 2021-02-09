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

            //carManager.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 500, ModelYear = 2020, Description = "320D" });

            //brandManager.Delete(new Brand { BrandName = "OPEL" });

            //colorManager.Update(new Color { Id = 3, ColorName = "KIRMIZI" });

            //carManager.Update(new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 520, ModelYear = 2019, Description = "C200D" });

            //CarGetAll(carManager);

            GetCarDetails(carManager);

        }

        private static void GetCarDetails(CarManager carManager)
        {
            foreach (var item in carManager.GetCarDetails())
            {
                System.Console.WriteLine(item.BrandName + " " + item.Description + " " + item.ColorName + " " + item.DailyPrice);
            }
        }

        private static void CarGetAll(CarManager carManager)
        {
            foreach (var car2 in carManager.GetAll())
            {
                System.Console.WriteLine(car2.Description + " "+ car2.DailyPrice);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetCarsByColorId(CarManager carManager)
        {
            System.Console.WriteLine("ColorId si 1 olan araçlar");
            foreach (var car1 in carManager.GetCarsByColorId(1))
            {
                System.Console.WriteLine(car1.Description + car1.ModelYear);
            }
        }

        private static void GetByBrandId(CarManager carManager)
        {
            System.Console.WriteLine("BrandId si 2 olan araçlar");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                System.Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ModelYear);
            }
        }
    }
}
