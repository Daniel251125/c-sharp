using System;

namespace PilaresdePOO
{
    class Perro:Mamifero
    {
        public int Tamano { get; set; }

        public void Ladrar()
        {
            Console.WriteLine("Gua Gua Gua Gua");
        }
    }
}