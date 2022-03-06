using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = 0;
            //while (number<10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //do
            //{
            //    Console.WriteLine("Başlangıç");
            //    number++;
            //} while (number<10);

            //int[] sayilar = new int[] { 1,2,3,45,6,47,8,94,5,12,3};
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            static bool IsPrimeNumber(int number)
            {
                int temp = 0;                
                for (int i = 2; i < number; i++)
                {
                    if(number % i == 0)
                    {
                        temp++;
                    }
                }

                if(temp > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            

        }
    }
}
