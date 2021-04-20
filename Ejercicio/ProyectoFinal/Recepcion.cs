public class Recepcionista: Persona
{
    public int Sueldo { get; set; }
    public string Sexo { get; set; }

    public Recepcionista(string nombre, int edad, string sexo, int telefono, string correo)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
        Telefono = telefono;
        Correo = correo;
    }
}