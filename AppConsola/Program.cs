using AppConsola;

RepositorioEmpleado empleadorepositorio = new RepositorioEmpleado();

empleadorepositorio.Eliminar ("1223456");
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

RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();
Empleado nuevoEmpleado = new Empleado("1006734936","David","Desarrollador", 20, 1001);

repositorioEmpleado.Actualizar("1111111111", nuevoEmpleado);

Console.ReadKey();