using System.Data;
using System.Data.SqlClient;
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
    
    //metodo para validar email y password (agent)
    public bool ValidationAgentLogin(string email, string password)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT COUNT(1) FROM Agent WHERE Email = @Email AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            
            int count = (int)command.ExecuteScalar();
            
            return count == 1;
        }
    }
}