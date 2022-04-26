using IoCContainer.Services.Interfaces;

namespace IoCContainer.Services
{
    public class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
