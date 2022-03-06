using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName="Fırat", LastName="Alçın", Age= 23 };
        }
    }

    class Customer{
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
    }
}
