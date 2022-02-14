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
            foreach (var item in productManager.GetProductDetail())
            {
                Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.CategoryName + " - " + item.UnitsInStock);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllByUnitPrice(40, 100))
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }
    }
}
