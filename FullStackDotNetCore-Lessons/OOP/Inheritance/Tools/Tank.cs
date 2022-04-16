using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tools
{
    public class Tank : SavasAraci
    {
        public override void Saldir()
        {
            Console.WriteLine("Hedefe top ateşleyerek saldırıldı");
        }
    }
}
