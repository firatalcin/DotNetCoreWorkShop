using System;

namespace Lesson_2_Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Bilgisayar";
            product1.unitPrice = 16000;
            product1.unitStock = 50;

            Product product2 = new Product();
            product2.productName = "Telefon";
            product2.unitPrice = 5000;
            product2.unitStock = 10;

            Product product3 = new Product();
            product3.productName = "Klavye";
            product3.unitPrice = 500;
            product3.unitStock = 100;

            Product[] urunler = new Product[]
            {
                product1,
                product2,
                product3
            };

            Console.WriteLine("-------------FOR-LOOP---------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].productName + " - " + urunler[i].unitPrice);
            }

            
            Console.WriteLine("-------------FOREACH---------------");

            foreach (var item in urunler)
            {
                Console.WriteLine(item.productName + " - " + item.unitPrice);
            }

            Console.WriteLine("-------------WHILE---------------");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].productName + " - " + urunler[j].unitPrice);
                j++;
            }
        }
    }

    class Product
    {
        public string productName { get; set; }
        public int unitPrice { get; set; }
        public int unitStock { get; set; }
    }
}
