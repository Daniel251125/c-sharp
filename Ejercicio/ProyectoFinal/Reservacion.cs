using System;
using System.Collections.Generic;

public class Reservacion
{
    public int CodigoReservacion { get; set; }
    public DateTime Fecha { get; set; }
    public int NumeroPersonas { get; set; }
    public string NReservacion { get; set; }
    public double Precio { get; set; }
    public Cliente Cliente { get; set; }
    public Recepcionista Recepcionista { get; set; }
    public Habitacion Habitacion { get; set; }

    public List <Reservaciondetalle> Reservaciondetalle { get; set; }

    public Reservacion(int codigoreservacion, DateTime fecha, int numeropersonas, string nreservacion, Cliente cliente, Recepcionista recepcionista, Habitacion habitacion)
    {
        CodigoReservacion = codigoreservacion;
        Fecha = fecha;
        NumeroPersonas = numeropersonas;
        NReservacion = nreservacion;
        Cliente = cliente;
        Recepcionista = recepcionista;
        Precio = habitacion.Precio;
        Reservaciondetalle = new List<Reservaciondetalle>();
    }

    public void NuevaReservacion(Habitacion habitacion)
    {
        int nuevahabitacion = Reservaciondetalle.Count + 1;
        int cantidad = 1;

        Reservaciondetalle o = new  Reservaciondetalle(nuevahabitacion, 1, habitacion);
        Reservaciondetalle.Add(o);
    }

}