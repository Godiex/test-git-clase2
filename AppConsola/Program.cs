using AppConsola;

RepositorioDepartamento repositorioDepartamento = new RepositorioDepartamento();
RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();
// repositorioDepartamento.Agregar("ARTES");
// repositorioDepartamento.Agregar("Ingenieria");
//repositorioDepartamento.Agregar("INGENIERIA");
//repositorioDepartamento.Eliminar(5);
//repositorioDepartamento.Actualizar(new Departamento(5, "CONTABILIDA-REGISTROS"));
repositorioEmpleado.Agregar(new Empleado("Luis","programador",23, 7,"1020"));
var departamentos = repositorioDepartamento.Consultar();
foreach (var item in departamentos)
{
    Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
}
Console.ReadKey();