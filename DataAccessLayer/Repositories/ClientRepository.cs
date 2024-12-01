using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class ClientRepository : IClientRepository
{
    private ISqlDataAccess _dbConnection;

    public ClientRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para obtener los clientes
    public DataTable GetClients()
    {
        DataTable clientsTable = new DataTable();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT client.Id, client.FirstName, client.LastName, client.Email, client.IdRol, Rol.NameRol AS Rol FROM Client INNER JOIN Rol ON client.IdRol = Rol.Id";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            clientsTable.Load(reader);
        }
        
        return clientsTable;
    }
    
    //metodo para insertar clientes
    public void InsertClient(Client client)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string quey = "INSERT INTO Client(FirstName, LastName, Email, Password, IdRol) VALUES (@FirstName, @LastName, @Email, @Password, 4)";
            SqlCommand command = new SqlCommand(quey, connection);
            command.Parameters.AddWithValue("@FirstName", client.FirstName);
            command.Parameters.AddWithValue("@LastName", client.LastName);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Password", client.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
    
    //metodo para actualizar clientes
    public void UpdateClient(Client client)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "UPDATE Client SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", client.IdClient);
            command.Parameters.AddWithValue("@FirstName", client.FirstName);
            command.Parameters.AddWithValue("@LastName", client.LastName);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Password", client.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    //metodo para eliminar cliente
    public void DeleteClient(int id)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "DELETE FROM Client WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
    
    //metodo para validar email y password
    public Client GetByEmailandPassword(string email, string password)
    {
        Client client = null;

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT * FROM Client WHERE Email = @Email and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                client = new Client()
                {
                    IdClient = (int)reader["id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString()
                };
            }
        }
        
        return client;
    }

    //metodo para validar si el email ya existe en la base de datos
    public bool VerifyEmailExist(string email)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT COUNT(1) FROM Client WHERE Email = @Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
            connection.Open();

            // Devuelve true si el conteo es mayor que 0
            return (int)command.ExecuteScalar() > 0;
        }
    }
}