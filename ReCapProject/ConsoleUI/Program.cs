using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{

    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarManager carManager = new CarManager(new EfCarDal());

            

            foreach (var item in carManager.GetCarDetail())
            {
                Console.WriteLine(item.CarName + " - " + item.BrandName + " - " + item.ColorName + " - " + item.DailyPrice);
            }
        }

        private static CarManager CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            return carManager;
        }
    }
}
