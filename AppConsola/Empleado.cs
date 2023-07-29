namespace AppConsola;

public class Empleado
{
    public string Id {get; set;} 
    public string Nombre { get; set; } = string.Empty;
    public string Cargo { get; set;} 
    public int Edad {get; set;}
    public int DepartamentoId {get; set;}

<<<<<<< HEAD
    public Empleado(string id, string nombre,string cargo,int edad,int departamentoId)
=======
    public Empleado(string nombre,string cargo,int edad,int departamentoId, string Id)
>>>>>>> 109301a87424987b5bd66e86ac833361056e73f3
    {
        Id = id;
        Nombre = nombre;
        Cargo = cargo;
        Edad = edad;
        DepartamentoId = departamentoId;
    }
}
 
