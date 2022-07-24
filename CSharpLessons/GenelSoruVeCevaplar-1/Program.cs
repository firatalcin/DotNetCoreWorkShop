namespace GenelSoruVeCevaplar_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1 - Namespace nedir : İçerisinde belirli sınıfları taşıyan gerektiğinde kodumuzda kullanarak yararlanacağımız yapılardır.

            //namespace kavramı bizim projelerimizde dahil ettiğimiz 3. parti kütüphanelerdir.

            #endregion 1 - Namespace nedir : İçerisinde belirli sınıfları taşıyan gerektiğinde kodumuzda kullanarak yararlanacağımız yapılardır.

            #region 2 - Strongly-Typed : C#'ta farklı veri türleriyle matematiksel işlemler yapılamaz

            string a = "5";
            int b = 10;
            //int topla = a + b; yapılamaz

            #endregion 2 - Strongly-Typed : C#'ta farklı veri türleriyle matematiksel işlemler yapılamaz

            #region 3 - Data Type sınıflandırılması : C#'ta iki tip veri sınıflandırması vardır. İlki gömülü olarak gelen tipler, ikincisi kullanıcının tanımladığı tipler

            int c = 20; // gömülü olarak gelen

            //class Ornek  = Kulanıcının tanımladığı

            #endregion 3 - Data Type sınıflandırılması : C#'ta iki tip veri sınıflandırması vardır. İlki gömülü olarak gelen tipler, ikincisi kullanıcının tanımladığı tipler

            #region 4 - Int ile Int32 arasında fark var mıdır : Herhangi bir fark yoktur. Int, Int32'nin kısaltılmış halidir.

            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(Int32));

            #endregion 4 - Int ile Int32 arasında fark var mıdır : Herhangi bir fark yoktur. Int, Int32'nin kısaltılmış halidir.

        }
    }
}