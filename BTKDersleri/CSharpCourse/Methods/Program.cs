using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(2, 6);
            int number1 = 20;
            int number2 = 100;
            var result = Add3(out number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(4,5,6,8,4,7,8,95,12,35,48,64,2,1));

        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2;
        }

        static int Add4(params int[] numbers)
        {
            int toplam = 0;
            foreach (var item in numbers)
            {
                toplam += item;
            }

            return toplam;
        }
    }
}
