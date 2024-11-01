using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.DbConnection;

public class SqlDataAccess: ISqlDataAccess
{
    private readonly string _connectionString;

    public SqlDataAccess()
    {
        _connectionString = "Data Source=LAPTOP-KFDQNCRJ\\SQLEXPRESS;Initial Catalog=SupportTicketSystemDB;Integrated Security=True;";
        //_connectionString = "Server=localhost,1433;Database=SupportTicketSystemDB;User Id=sa;Password=TuPasswordSegura123(!);";
    }

    public IDbConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }

}