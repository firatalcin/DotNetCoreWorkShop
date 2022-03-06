using System;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;

            number1 = 30;

            Console.WriteLine(number2);

            int[] sayilar1 = { 1,2,3,4,5 };
            int[] sayilar2 = { 10, 11, 12, 13, 14, 15 };
            sayilar2 = sayilar1;
            sayilar1[0] = 16;
            Console.WriteLine(sayilar2[0]);

        }
    }
}
