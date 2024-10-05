using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class TicketRepository
{
    private SqlDataAccess _dbConnection;

    public TicketRepository()
    {
        _dataAccess = new SqlDataAccess();
    }
    
    //metodo para ver los ticket desde la vista (client o agent)
    public DataTable GetTicketsByClient()
    {
        DataTable ticketsTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT  NameTicket, DescriptionTicket, Priority, Status FROM Tickets";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            ticketsTable.Load(reader);
        }
        return ticketTable;
    }

    //metodo para ver los ticket desde la vista (administrador)
    public DataTable GetTicketsByAdmin()
    {
        DataTable ticketsTable = new DataTable();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT NameTicket, DescriptionTicket, Priority, Status, Id_Client, Id_Agent FROM Tickets";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            SqlDateReader = command.ExecuteReader();
            ticketsTable.Load(reader);
        }
        return ticketsTable;
    }

    //metodo para agregar ticket desde client
    public void AddTicked(Ticket ticket, Client client)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Ticket(NameTicket, DescriptionTicket, Priority, Status, Id_Client) VALUES (@NameTicket, @DescriptionTicket, @Priority, @Status, @Id_Client)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NameTicket", ticket.NameTicket);
            command.Parameters.AddWithValue("@DescriptionTicket", ticket.DescriptionTicket);
            command.Parameters.AddWithValue("@Priority", ticket.Priority);
            command.Parameters.AddWithValue("@Status", ticket.Status);
            command.Parameters.AddWithValue("@Id_Client", client.Id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    //metodo para actualizar descripcion y prioridad (client)
    public void UpdateTicketByClient(int Id, string Description, string Priority)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Ticket SET Description = @Description, Priority = @Priority WHERE Id_Client = @Id_Client";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Priority", Priority);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
        
    }

    //metodo para actualizar estado y id_Agent (administrador)
    public void UpdateTicketByAdmin(int Id, string Status, int Id_Agent)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Ticket SET Status = @Status, Id_Agent = @Id_Agent WHERE Id_Client = @Id_Client";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@Id_Agent", Id_Agent);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}