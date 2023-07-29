using Microsoft.Data.SqlClient;

namespace AppConsola;

public class RepositorioDepartamento
{
    public void Agregar(string nombre)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("INSERT INTO Departamentos (Nombre) VALUES (@Nombre)", conexion);
        cmd.Parameters.AddWithValue("@Nombre", nombre);
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
