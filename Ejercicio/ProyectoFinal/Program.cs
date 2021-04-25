using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            opciones nopcion = new opciones();
            string opcion ="";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("********************************************************");
                Console.WriteLine("");
                Console.WriteLine("********Bienvenido al Sistema de Reservacion********");
                Console.WriteLine("");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("");
                Console.WriteLine(" 1. --Nuevo Cliente");
                Console.WriteLine(" 2. --Nuevo Reservacion");
                Console.WriteLine(" 3. --Lista de Habitaciones disponibles");
                Console.WriteLine(" 4. --Lista de Reservaciones");
                Console.WriteLine(" 5. --Lista de Clientes Hospedados");
                Console.WriteLine(" 6. --Salir");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                    nopcion.nuevocliente();
                    break;                    
                default:
                    break;
                }
                 if(opcion=="6")
                 {
                     break;
                 }
            }

        }
    }
}
