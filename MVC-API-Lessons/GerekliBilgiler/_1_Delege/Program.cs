using System;

namespace _1_Delege
{
    public class Program
    {
        //Delegate'ler sırasıyla methodları tetikleyen yapılardır.
        delegate void MyDelegate(int number1, int number2);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Sum);
            myDelegate += Multi;
            myDelegate.Invoke(1, 2);
        }

        static void Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Multi(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
    }
}
