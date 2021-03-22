using System;
namespace PilaresdePOO
{
    abstract class Mamifero: Animal
    {
        public int Patas { get; set; }

        public string Tanimal { get; set; }

        public void Caminar()
        {
            Console.WriteLine("Caminando...");
        }
    }
}