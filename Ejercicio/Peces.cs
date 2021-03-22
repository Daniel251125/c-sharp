using System;

namespace PilaresdePOO
{
    abstract class Peces:Animal
    {
        public int NumeroAletas { get; set; }

        public void Nadar()
        {
            Console.WriteLine("Nada...");
        }
    }
}