using System;
namespace PilaresdePOO
{
    abstract class Aves: Animal
    {

        public string NombreAve { get; set; }

        public string ColorPlumaje { get; set; }
        
        public void Volar()
        {
            Console.WriteLine("Vuela...");
        }
    }
}