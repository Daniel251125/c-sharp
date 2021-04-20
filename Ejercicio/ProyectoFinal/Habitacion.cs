public class Habitacion
{
    public int Codigo { get; set; }
    public string TipoHabitacion { get; set; }
    public int NCamas { get; set; }
    public double Precio { get; set; }

    public Habitacion(int codigo, string tipohabitacio, int ncamas, double precio)
    {
        Codigo = codigo;
        TipoHabitacion = tipohabitacio;
        NCamas = ncamas;
        Precio = precio;
    }
}