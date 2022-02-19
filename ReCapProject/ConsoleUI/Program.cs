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

            var result = carManager.GetCarDetail();

            if (result.IsSuccess)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + " - " + item.BrandName + " - " + item.ColorName + " - " + item.DailyPrice);
                }
            }
            

            
        }

        
    }
}
