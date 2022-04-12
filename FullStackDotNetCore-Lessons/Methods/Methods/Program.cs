using System;

namespace Methods
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            //Hello();
            //Sum(5,10);
            //Console.WriteLine(Sum2(2,4));
            //SendCopy(number);
            //Console.WriteLine(number);
            //RefCopy(ref number);
            //Console.WriteLine(number);
            int number1;
            int number2;
            Play(out number1, out number2);
        }

        #region Ders 1 - Method Nedir ?
        //public static void Hello()
        //{
        //    Console.WriteLine("Merhaba");
        //} 
        #endregion

        #region Ders 2 - Method Parametresi
        //public static void Sum(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}

        //public static int Sum2(int x, int y)
        //{
        //    return x + y;
        //}
        #endregion

        #region Ders 3 -  Ders 3 - Default Parametresi
        //public static void Hello(int x,string name = "fırat")
        //{
        //    Console.WriteLine(name);
        //}
        #endregion

        #region Ders 4 - Method Overloading
        //public static void Sum(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}

        //public static void Sum(int x, int y, int z)
        //{
        //    Console.WriteLine(x + y + z);
        //}
        #endregion

        #region Ders 5 - ref Keyword
        //ref de ilk değer verilmesi zorunludur.
        //static int number = 20;
        //public static void SendCopy(int copyNumber)
        //{
        //    copyNumber = 40;
        //}

        //public static void RefCopy(ref int refCopy)
        //{
        //    refCopy = 50;
        //}
        #endregion

        #region Ders 6 - out Keyword
        // out da ilk değer verilmesi zorunlu değildir ama method içinde değiştirilmeli
        public static string Play(out int number1, out int number2)
        {
            number1 = 0;
            number2 = 0;
            return "Kazandınız";
        }
        #endregion
    }
}
