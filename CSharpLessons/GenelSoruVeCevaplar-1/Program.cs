namespace GenelSoruVeCevaplar_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1 - Namespace nedir : İçerisinde belirli sınıfları taşıyan gerektiğinde kodumuzda kullanarak yararlanacağımız yapılardır.

            //namespace kavramı bizim projelerimizde dahil ettiğimiz 3. parti kütüphanelerdir.

            //2 - Strongly-Typed : C#'ta farklı veri türleriyle matematiksel işlemler yapılamaz

            string a = "5";
            int b = 10;
            //int topla = a + b; yapılamaz

            //3 - Data Type sınıflandırılması : C#'ta iki tip veri sınıflandırması vardır. İlki gömülü olarak gelen tipler, ikincisi kullanıcının tanımladığı tipler

            int c = 20; // gömülü olarak gelen

            //class Ornek  = Kulanıcının tanımladığı

            //4 - Int ile Int32 arasında fark var mıdır : Herhangi bir fark yoktur. Int, Int32'nin kısaltılmış halidir.

            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(Int32));

            //5 - Value Types ve Reference Types arasındaki fark nedir ? : value types stack'te tutulurken, reference types heap'te tutularak stack'te referansı tutulur.

            int v = 5; // Stack'te tutulan veriler genellikte tek bir variable tutumunda kullanılır.
            string r = "reference"; // Heap'te tutulan veriler genellikle bir veri kümesine sahip nesnelerdir. Bu nesnelerin referansı ile stack'te bir değişken oluşturulabilir.

            //6 - Property Nedir ? : Bir class'taki private değerleri hep okuyup hem değiştirebileceğimiz encapsulation uygulayabileceğimiz yapılardır.

            Ogrenci ogrenci = new();
            ogrenci.FirstName = "Fırat";

            //7 - Access Modifiers : Erişim belirleyiciler field, property veya bir class'ın görünümünü kısıtlayabilir.

            //public : Bütün classlardan ulaşılabilir
            //private : Sadece oluşturulduğu class'ta erişilebilir
            //internal : Sadece oluşturulduğu proje içerisinde erişilebilir
            //protected : Sadece oluşturulduğu class ve miras alınan class'ta erişilir.
        }
    }

    internal class Ogrenci
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Number { get; set; }
    }
}