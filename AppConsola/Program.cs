using AppConsola;

RepositorioDepartamento repositorioDepartamento = new RepositorioDepartamento();
//repositorioDepartamento.Agregar("GASTRONOMIA");
//repositorioDepartamento.Agregar("FILOSOFIA");
repositorioDepartamento.Eliminar(9);
//repositorioDepartamento.Agregar("INGENIERIA");
repositorioDepartamento.Actualizar(new Departamento(5, "CONTABILIDA-REGISTROS"));
var departamentos = repositorioDepartamento.Consultar();
foreach (var item in departamentos)
{
    Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
}
Console.ReadKey();