using Polimorphism.Models;
using System;

namespace Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitki bitki = new Bitki();
            Insan insan = new Insan();

            insan.NefesAl();
            bitki.NefesAl();
        }
    }
}
