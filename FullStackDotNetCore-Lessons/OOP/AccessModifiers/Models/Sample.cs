using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    public class Sample
    {
        public string publicProperty { get; set; }
        internal string internalProperty { get; set; }
        private string privateProperty { get; set; }

        string privateVariable;

        internal void Test()
        {
            Console.WriteLine("test");
        }
    }
}
