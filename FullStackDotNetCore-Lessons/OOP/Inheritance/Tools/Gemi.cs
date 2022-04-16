using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tools
{
    public class Gemi : SavasAraci
    {
        public override void Saldir()
        {
            Console.WriteLine("Hedef batırıldı");
        }
    }
}
