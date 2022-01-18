using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Adana");
            //cities.Add("İstanbul");
            //cities.Add(1);
            //cities.Add('A');

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("Adana");
            //cities.Add("İstanbul");

            //cities.Contains("Ankara");

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1,FirstName="Fırat"});
            //customers.Add(new Customer { Id = 2, FirstName = "Celil" });

            //var count = customers.Count;
            //var customer = new Customer { Id = 3, FirstName = "Halil" };
            //customers.Add(customer);
            //customers.AddRange(new Customer[2]
            //{
            //    new Customer { Id = 4, FirstName ="Enes"},
            //    new Customer { Id = 5, FirstName ="Fıat"}
            //});

            //customers.Clear();

            ////int index = customers.IndexOf(customers.Contains(customer));
            //customers.Insert(0, customer);
            //customers.Remove(customer);
            //customers.RemoveAll(c => c.FirstName == "Fırat");
           


            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Computer", "Bİlgisayar");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("Book"));
            Console.WriteLine(dictionary.ContainsKey("Computer"));


        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
