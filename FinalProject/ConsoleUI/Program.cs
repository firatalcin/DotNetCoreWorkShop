using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //IoC
            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetail();

            if(result.IsSuccess == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.CategoryName + " - " + item.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
