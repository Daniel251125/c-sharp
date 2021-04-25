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
    public Habitacion Habitacion { get; set; }

    public Reservacion(int codigoreservacion, DateTime fecha, int numeropersonas, string nreservacion, Cliente cliente,  Habitacion habitacion)
    {
        CodigoReservacion = codigoreservacion;
        Fecha = fecha;
        NumeroPersonas = numeropersonas;
        NReservacion = nreservacion;
        Cliente = cliente;
        Precio = habitacion.Precio;
        
    }

}