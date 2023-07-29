using Microsoft.Data.SqlClient;

namespace AppConsola;
using Microsoft.Data.SqlClient;
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

    public List<Departamento> Consultar()
    {
        List<Departamento> departamentos = new List<Departamento>();
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("SELECT *  FROM Departamentos", conexion);
        conexion.Open();
        using SqlDataReader dataReader = cmd.ExecuteReader();
        if (dataReader.HasRows)
        {
            while(dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string nombre = dataReader.GetString(1);
                Departamento departamento = new Departamento(id, nombre);
                departamentos.Add(departamento);
            }
        }
        dataReader.Close();
        conexion.Close();
        return departamentos;
    }

    public void Eliminar(int id)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("DELETE Departamentos WHERE Id = @id;", conexion);
        cmd.Parameters.AddWithValue("@id", id);
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
