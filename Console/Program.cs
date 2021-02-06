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
            System.Console.WriteLine("BrandId si 2 olan araçlar");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                System.Console.WriteLine(car.Description + " " + car.DailyPrice + " " +car.ModelYear);
            }

            System.Console.WriteLine("ColorId si 1 olan araçlar");
            foreach (var car1 in carManager.GetCarsByColorId(1))
            {
                System.Console.WriteLine(car1.Description+car1.ModelYear);
            }

            carManager.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 500, ModelYear = 2020, Description = "320D" });
            foreach (var car2 in carManager.GetAll())
            {
                System.Console.WriteLine(car2.Description);
            }

            System.Console.ReadLine();

  

        }
    }
}
