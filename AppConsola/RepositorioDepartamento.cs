using Microsoft.Data.SqlClient;

namespace AppConsola;
using Microsoft.Data.SqlClient;
public class RepositorioDepartamento
{
     
    public void Agregar(string nombre)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        conexion.Open();
        using SqlCommand cmd = new SqlCommand("INSERT INTO Departamentos (Nombre) VALUES (@Nombre)", conexion);
        cmd.Parameters.AddWithValue("@Nombre", nombre);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
