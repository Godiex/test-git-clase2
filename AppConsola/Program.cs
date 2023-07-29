using AppConsola;

RepositorioDepartamento repositorioDepartamento = new RepositorioDepartamento();
// repositorioDepartamento.Agregar("ARTES");
// repositorioDepartamento.Agregar("Ingenieria");
//repositorioDepartamento.Agregar("INGENIERIA");
repositorioDepartamento.Eliminar(5);
var departamentos = repositorioDepartamento.Consultar();
foreach (var item in departamentos)
{
    Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
}
Console.ReadKey();