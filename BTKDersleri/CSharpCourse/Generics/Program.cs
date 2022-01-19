using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity
    {
        
    }

    interface IProductDal : IRepository<Product>
    {
        
    }

    class Customer : IEntity
    {
        
    }

    interface ICustomerDal : IRepository<Customer>
    {
        
    }

    interface IEntity
    {

    }

    interface IRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }


}
