using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class AdministradorRepository
{
    private SqlDataAccess _dbConnection;

    public AdministradorRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para obtener los datos del administrador
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

    public void AddAdministrador(administrador administrador)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Administrador(FirstName, LastName, Email, Password, IdRol) VALUES(@FirstName, @LastName, @Email, @Password, 1)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", administrador.FirstName);
            command.Parameters.AddWithValue("@LastName", administrador.LastName);
            command.Parameters.AddWithValue("@Email", administrador.Email);
            command.Parameters.AddWithValue("@Password", administrador.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void UpdateAdministrador(administrador administrador)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Administrador SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", administrador.FirstName);
            command.Parameters.AddWithValue("@LastName", administrador.LastName);
            command.Parameters.AddWithValue("@Email", administrador.Email);
            command.Parameters.AddWithValue("@Password", administrador.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}