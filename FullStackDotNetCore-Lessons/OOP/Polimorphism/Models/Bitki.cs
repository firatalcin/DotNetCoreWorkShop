﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Models
{
    public class Bitki : Canli
    {
        public override void NefesAl()
        {
            Console.WriteLine("Fotosentez yap");
        }
    }
}