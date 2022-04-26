using IoCContainer.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Text;

namespace IoCContainer.Services
{
    public class TextLogger : ILog
    {
        string path;

        public TextLogger(IHostEnvironment env)
        {
            string date = DateTime.Now.ToString("d-M-yyyy");
            path = $"{env.ContentRootPath}/Logs/{date}.txt";
            try
            {
                if (!File.Exists(path))
                {
                    using (File.Create(path))
                    {

                    };
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Info(string message)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true, Encoding.UTF8))
                {
                    string time = DateTime.Now.ToString("HH:mm");
                    stream.WriteLine($"##INFO## &&{time}&& || message: {message}");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
