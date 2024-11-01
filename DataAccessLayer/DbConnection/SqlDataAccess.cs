namespace DataAccessLayer.DbConnection;

public class SqlDataAccess: ISqlDataAccess
{
    private readonly string _connectionString;

    public SqlDataAccess()
    {
        _connectionString = "Server=localhost,1433;Database=SupportTicketSystemDB;User Id=sa;Password=TuPasswordSegura123(!);";
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }
}