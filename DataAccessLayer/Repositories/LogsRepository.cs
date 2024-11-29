using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;


namespace DataAccessLayer.Repositories;

public class LogsRepository : ILogsRepository
{
    private ISqlDataAccess _dbConnection;

    public LogsRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    public DataTable GetAllLogs()
    {
        DataTable LogsTable = new DataTable();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
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
}