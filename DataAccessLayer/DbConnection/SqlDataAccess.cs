using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.DbConnection;

public class SqlDataAccess
{
    private readonly string _connectionString;

    public SqlDataAccess()
    {
        _connectionString = "Data Source=LAPTOP-KFDQNCRJ\\SQLEXPRESS;Initial Catalog=SupportTicketSystemDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //_connectionString = "Server=localhost,1433;Database=SupportTicketSystemDB;User Id=sa;Password=TuPasswordSegura123(!);";
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }               
}