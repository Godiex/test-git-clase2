using Microsoft.Data.SqlClient;
namespace AppConsola;

public class RepositorioEmpleado
{
    public void Eliminar( string id)
    {
         using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("DELETE Empleados WHERE Id = @id;", conexion);
        cmd.Parameters.AddWithValue("@id", id);
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();

    }
}
