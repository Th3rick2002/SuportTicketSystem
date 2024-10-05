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