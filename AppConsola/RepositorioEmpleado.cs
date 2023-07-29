namespace AppConsola;
using Microsoft.Data.SqlClient;
public class RepositorioEmpleado 
{
    public void Agregar( Empleado empleado)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (Nombre, Id, Cargo, DepartamentoId, Edad) VALUES (@Nombre, @Id, @Cargo, @DepartamentoId, @Edad)", conexion);
        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        cmd.Parameters.AddWithValue("@Id", empleado.Id);
        cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
        cmd.Parameters.AddWithValue("@DepartamentoId", empleado.DepartamentoId );
        cmd.Parameters.AddWithValue("@Edad", empleado.Edad );
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
