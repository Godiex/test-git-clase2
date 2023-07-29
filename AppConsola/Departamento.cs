namespace AppConsola;

public class Departamento
{
    public int Id { get; private set; }
    public string Nombre { get; set; } = string.Empty;

    public Departamento(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}
