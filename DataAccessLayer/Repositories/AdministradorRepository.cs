using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class AdministradorRepository
{
    private SqlDataAccess _dbConnection;

    public AdministradorRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //motodo para obtener los datos del administrador
    public DataTable GetAdmins()
    {
        DataTable dataTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT * FROM Administrador";
            SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();
        }
        return dataTable;
    }
    
    //metodo para validar email y password (administrador)
    public bool ValidationAdministradorLogin(string email, string password)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT COUNT(1) FROM Administrador WHERE Email = @Email AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            
            int count = (int)command.ExecuteScalar();
            
            return count == 1;
        }
    }
}