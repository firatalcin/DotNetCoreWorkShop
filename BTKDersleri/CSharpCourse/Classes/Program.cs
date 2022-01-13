using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Fırat";
            customer1.LastName = "Alçın";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer()
            {
                FirstName = "Engin",
                LastName = "Demirog",
                Id = 2,
                City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }

    

    
}
