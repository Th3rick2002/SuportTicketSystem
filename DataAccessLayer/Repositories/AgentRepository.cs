using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class AgentRepository
{
    private SqlDataAccess _dbConnection;

    public AgentRepository()
    {
        _dbConnection = new SqlDataAccess();
    }
    
    //metodo para obtener todos los agentes
    public DataTable GetAgents()
    {
        DataTable agentsTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT Id, FirstName, LastName, Email FROM Agent";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            agentsTable.Load(reader);
        }
        
        return agentsTable;
    }

    //metodo para insertar agentes
    public void InsertAgent(Agent agent)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string quey = "INSERT INTO Agent(FirstName, LastName, Email, Password, availability, IdRol) VALUES (@FirstName, @LastName, @Email, @Password, 0, 2)";
            SqlCommand command = new SqlCommand(quey, connection);
            command.Parameters.AddWithValue("@FirstName", agent.FirstName);
            command.Parameters.AddWithValue("@LastName", agent.LastName);
            command.Parameters.AddWithValue("@Email", agent.Email);
            command.Parameters.AddWithValue("@Password", agent.Password);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    //metodo para actualizar agentes
    public void UpdateAgent(Agent agent)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Agent SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password, availability = @availability WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", agent.FirstName);
            command.Parameters.AddWithValue("@LastName", agent.LastName);
            command.Parameters.AddWithValue("@Email", agent.Email);
            command.Parameters.AddWithValue("@Password", agent.Password);
            command.Parameters.AddWithValue("@availability", agent.availability);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    //metodo para eliminar agentes
    public void DeleteAgent(int id)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "DELETE FROM Agent WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}