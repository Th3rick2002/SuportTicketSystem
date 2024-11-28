using System.Data;

namespace DataAccessLayer.DbConnection;

public interface ISqlDataAccess
{ 
    IDbConnection GetConnection();
}