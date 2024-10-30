using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class LogsRepository
{
    private SqlDataAccess _dbConnection;

    public LogsRepository()
    {
        _dbConnection = new SqlDataAccess();
    }
    
    
}