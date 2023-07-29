namespace AppConsola;
using Microsoft.Data.SqlClient;

public class RepositorioEmpleado
{
    public void Actualizar(string idEmpleadoActualizar, Empleado empleado)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("UPDATE Empleados SET Id = @idActualizar, Nombre = @nombre, Cargo = @cargo, Edad = @edad WHERE Id = @id;", conexion);
        cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
        cmd.Parameters.AddWithValue("@cargo", empleado.Cargo);
        cmd.Parameters.AddWithValue("@edad", empleado.Edad);
        cmd.Parameters.AddWithValue("@idActualizar", empleado.Id);
        cmd.Parameters.AddWithValue("@id", idEmpleadoActualizar);
        conexion.Open();
          cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
