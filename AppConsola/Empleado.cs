namespace AppConsola;

public class Empleado
{
    public string Id {get; set;} 
    public string Nombre { get; set; } = string.Empty;
    public string Cargo { get; set;} 
    public int Edad {get; set;}
    public int DepartamentoId {get; set;}

    public Empleado(string id, string nombre,string cargo,int edad,int departamentoId)
    {
        Id = id;
        Nombre = nombre;
        Cargo = cargo;
        Edad = edad;
        DepartamentoId = departamentoId;
    }
}
 
