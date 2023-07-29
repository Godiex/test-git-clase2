namespace AppConsola;

public class Departamento
{
    public int Id { get; private set; }
    public string Nombre { get; set; } = string.Empty;

    public Departamento(string nombre)
    {
        Nombre = nombre;
    }
}
