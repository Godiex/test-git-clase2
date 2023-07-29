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
    public List<Empleado> ConsultarEmpleado()
    {
        List<Empleado> empleados = new List<Empleado>();
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados ", conexion);
        conexion.Open();
        using SqlDataReader dataReader = cmd.ExecuteReader();
        if (dataReader.HasRows)
        {
            while (dataReader.Read())
            {
                string id = dataReader.GetInt32(0).ToString();
                string nombre = dataReader.GetString(1);
                string cargo = dataReader.GetString(1);
                int edad = dataReader.GetInt32(0);
                int departamentoId = dataReader.GetInt32(0);
                Empleado empleado = new Empleado(id, nombre, cargo, edad, departamentoId);
                empleados.Add(empleado);
            }
        }
        dataReader.Close();
        conexion.Close();
        return empleados;
    }
    public void Agregar(Empleado empleado)
    {
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (Nombre, Id, Cargo, DepartamentoId, Edad) VALUES (@Nombre, @Id, @Cargo, @DepartamentoId, @Edad)", conexion);
        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        cmd.Parameters.AddWithValue("@Id", empleado.Id);
        cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
        cmd.Parameters.AddWithValue("@DepartamentoId", empleado.DepartamentoId);
        cmd.Parameters.AddWithValue("@Edad", empleado.Edad);
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
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
    }
}
