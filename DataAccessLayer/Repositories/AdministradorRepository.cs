using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class AdministradorRepository : IAdministradorRepository
{
    private ISqlDataAccess _dbConnection;

    public AdministradorRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para obtener los datos del administrador
    public DataTable GetAdmins()
    {
        DataTable dataTable = new DataTable();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT * FROM Administrador";
            SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();
        }
        return dataTable;
    }

    //metodo para agregar
    public void AddAdministrador(administrador administrador)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
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

    //metodo para actualizar
    public void UpdateAdministrador(administrador administrador)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
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
    
    //metodo para validar el email y password
    public administrador GetByEmailAndPassword(string email, string password)
    {
        administrador administrador = null;

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT * FROM Administrador WHERE Email = @Email AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                administrador = new administrador();
                {
                    administrador.Id = (int)reader["Id"];
                    administrador.FirstName = reader["FirstName"].ToString();
                    administrador.LastName = reader["LastName"].ToString();
                    administrador.Email = reader["Email"].ToString();
                    administrador.Password = reader["Password"].ToString();
                    administrador.idRol = (int)reader["IdRol"];
                }
            }

            return administrador;
        }
    }
}