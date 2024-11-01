using System.Data;
using System.Data.SqlClient;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class TicketRepository : ITicketRepository
{
    private ISqlDataAccess _dbConnection;

    public TicketRepository()
    {
        _dbConnection = new SqlDataAccess();
    }
    
    //metodo para ver los ticket
    public DataTable GetTicketsByClient()
    {
        DataTable ticketsTable = new DataTable();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT  NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, Id_Client, Id_Agent FROM Tickets";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            ticketsTable.Load(reader);
        }
        return ticketsTable;
    }

    //metodo para agregar ticket
    public void AddTicked(Ticket ticket, Client client)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "INSERT INTO Ticket(NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, Id_Client) VALUES (@NameTicket, @DescriptionTicket, @Priority, @Status, @Categorie, @Tag, @Id_Client)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NameTicket", ticket.NameTicket);
            command.Parameters.AddWithValue("@DescriptionTicket", ticket.DescriptionTicket);
            command.Parameters.AddWithValue("@Priority", ticket.Priority);
            command.Parameters.AddWithValue("@Categorie", ticket.categorie);
            command.Parameters.AddWithValue("@Tag", ticket.tag);
            command.Parameters.AddWithValue("@Status", ticket.Status);
            command.Parameters.AddWithValue("@Id_Client", client.IdClient);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    //metodo para actualizar ticket
    public void UpdateTicketByAdmin(Ticket ticket, Agent agent)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "UPDATE Ticket SET NameTicket = @NameTicket, DescriptionTicket = @DescriptionTicket, Priority = @Priority, Categorie = @Categorie, Tag = @Tag, Id_Agent = @Id_Agent WHERE Id_Client = @Id_Client";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NameTicket", ticket.NameTicket );
            command.Parameters.AddWithValue("@DescriptionTicket", ticket.DescriptionTicket);
            command.Parameters.AddWithValue("@Priority", ticket.Priority);
            command.Parameters.AddWithValue("@Categorie", ticket.categorie);
            command.Parameters.AddWithValue("@Tag", ticket.tag);
            command.Parameters.AddWithValue("@Id_Agent", agent.IdAgent);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    
    public void DeleteTicketByAdmin(Ticket ticket, Agent agent)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "DELETE FROM Ticket WHERE Id_Client = @Id_Client";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id_Client", ticket.IdClient);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}