using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 10;
            int number7 = 10;
            Console.WriteLine(number7);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(condition);
            Console.WriteLine(character);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine((int)Days.Monday);
        }
    }

    enum Days
    {
        Monday = 1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
