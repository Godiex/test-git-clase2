using Microsoft.Data.SqlClient;
namespace AppConsola;

public class RepositorioEmpleado
{
    public List<Empleado> ConsultarEmpleado()
    {
        List<Empleado> empleados = new List<Empleado>();
        using SqlConnection conexion = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados ", conexion);
        conexion.Open();
        using SqlDataReader dataReader = cmd.ExecuteReader();
        if (dataReader.HasRows)
        {
            while(dataReader.Read())
            {
                string id = dataReader.GetInt32(0).ToString();
                string nombre = dataReader.GetString(1);
                string cargo = dataReader.GetString(1);
                int edad = dataReader.GetInt32(0);
                int departamentoId = dataReader.GetInt32(0);
                Empleado empleado = new Empleado(id, nombre, cargo, edad,departamentoId);
                empleados.Add(empleado);
            }
        }
        dataReader.Close();
        conexion.Close();
        return empleados;
    }
}
