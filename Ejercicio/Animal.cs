using System;
namespace PilaresdePOO
{
    abstract class Animal
    {
        public int CodigoAnimal { get; set; }
        public string TipoAnimal { get; set; }

        public void Comer()
        {
            Console.WriteLine("Comiendo...");
        }
    }


}