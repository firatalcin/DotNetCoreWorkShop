using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("****************************************");

            foreach (var item in carManager.GetAllByColorId(2))
            {
                Console.WriteLine(item.Description);
            }
           
        }
    }
}
