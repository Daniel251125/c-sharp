using System;
using System.Collections.Generic;


public class opciones
{
    public List<Cliente> ListadeClientes { get; set; }
    
    public List<Reservacion> ListadeReservacion { get; set; }
    public List<Habitacion> ListaHabitacion { get; set; }


    public opciones()
    {
        ListadeClientes = new List<Cliente>();
        nuevocliente();

    }

    public void nuevocliente()
    {
        Console.WriteLine("Ingrese los datos que se le piden");
        Console.WriteLine("");

        Console.WriteLine("Codigo del Cliente");
        int ncodigo = ListadeClientes.Count +1;
    }
}