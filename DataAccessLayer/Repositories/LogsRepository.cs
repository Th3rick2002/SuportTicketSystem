using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;


namespace DataAccessLayer.Repositories;

public class LogsRepository
{
    private SqlDataAccess _dbConnection;

    public LogsRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    public DataTable GetAllLogs()
    {
        DataTable LogsTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = 
                "SELECT"+
                    "Logs.Id,"+
                    "Logs.TicketId,"+    
                    "Logs.Time,"+
                    "Logs.Details,"+
                    "Agent.FirstName AS AgentName,"+
                    "Client.FirstName AS ClientName"+
                "FROM Logs"+         
                    "INNER JOIN Client ON Logs.ClientId = Client.Id"+
                    "INNER JOIN Agent ON Logs.AgentId = Agent.Id;";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
        
        return LogsTable;
    }

    public void InsertLog(Logs logs)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Logs(TicketId, ClientId, AgentId, Time, Details) VALUES(@TicketId, @ClientId, @AgentId, GETDATE(), @Details)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TicketId", logs.TicketId);
            command.Parameters.AddWithValue("@ClientId", logs.AgentId);
            command.Parameters.AddWithValue("@AgentId", logs.AgentId);
            command.Parameters.AddWithValue("@Details", logs.Details);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}