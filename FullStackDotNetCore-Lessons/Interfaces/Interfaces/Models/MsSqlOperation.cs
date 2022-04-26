namespace Interfaces.Models
{
    public class MsSqlOperation : Test, ISqlOperation , ITestInterface
    {
        public void Connection()
        {
            System.Console.WriteLine("MsSql için bağlantı sağlandı");
        }

        public bool Insert(Product product)
        {
            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }
    }

    public class MySqlOperation : ISqlOperation
    {
        public void Connection()
        {
            System.Console.WriteLine("MySql için bağlantı sağlandı");
        }

        public bool Insert(Product product)
        {
            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }
    }

    public interface ISqlOperation
    {
        void Connection();
        bool Insert(Product product);
        bool Update(Product product);
    }

    public interface ITestInterface
    {

    }

    public class Test
    {

    }
}
