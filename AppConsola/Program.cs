﻿using AppConsola;

RepositorioDepartamento repositorioDepartamento = new RepositorioDepartamento();
//repositorioDepartamento.Agregar("INGENIERIA");
repositorioDepartamento.Actualizar(new Departamento(5, "CONTABILIDA-REGISTROS"));
var departamentos = repositorioDepartamento.Consultar();
foreach (var item in departamentos)
{
    Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
}

RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();
Empleado nuevoEmpleado = new Empleado("1006734936","David","Desarrollador", 20, 1001);

repositorioEmpleado.Actualizar("1111111111", nuevoEmpleado);

Console.ReadKey();