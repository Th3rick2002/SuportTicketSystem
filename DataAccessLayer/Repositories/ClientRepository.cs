using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class ClientRepository
{
    private SqlDataAccess _dbConnection;

    public ClientRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para obtener los clientes
    public DataTable GetClients()
    {
        DataTable clientsTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT Id, FirstName, LastName, Email FROM Clients";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            clientsTable.Load(reader);
        }
        
        return clientsTable;
    }

    //metodo para agregar cliente
    public void AddClient(Client client)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Client VALUES(@FirstName, @LastName, @Email, @Password)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", client.FirstName);
            command.Parameters.AddWithValue("@LastName", client.LastName);
            command.Parameters.AddWithValue("@Email", client.Email);
            command.Parameters.AddWithValue("@Password", client.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
    
    //metodo para insertar clientes
    public void InsertClient(Client client)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string quey = "INSERT INTO Client(FirstName, LastName, Email, Password, IdRol) VALUES (@FirstName, @LastName, @Email, @Password, 3)";
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
        using (var connection = _dbConnection.GetConnection())
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
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "DELETE FROM Client WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}