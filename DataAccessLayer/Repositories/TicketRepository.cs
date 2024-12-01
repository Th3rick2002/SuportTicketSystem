using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using CommonLayer.Entities;
using Dapper;
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
    public DataTable GetTickets()
    {
        DataTable ticketsTable = new DataTable();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT " +
                    "ticket.IdTicket, " +
                    "ticket.NameTicket, " +
                    "ticket.DescriptionTicket, " +
                    "ticket.Priority, " +
                    "ticket.Status, " +
                    "Categories.NameCategorie AS Categorie, " +
                    "Tag.NameTag AS Tag, " +
                    "Client.FirstName + ' ' + Client.LastName AS Client, " +
                    "COALESCE(Agent.FirstName + ' ' + Agent.LastName, 'Sin asignar') AS Agent, " +
                    "ticket.Categorie AS IdCategorie, " +
                    "ticket.Tag AS IdTag, " +
                    "ticket.Id_Agent AS IdAgent, " +
                    "ticket.Id_Client AS IdClient " +
                "FROM Ticket " +
                    "INNER JOIN Categories ON ticket.Categorie = Categories.Id " +
                    "INNER JOIN Tag ON ticket.Tag = Tag.Id " +
                    "INNER JOIN Client ON ticket.Id_Client = Client.Id " +
                    "LEFT JOIN Agent ON ticket.Id_Agent = Agent.Id;";

            using (var reader = connection.ExecuteReader(query))
            {
                ticketsTable.Load(reader);
            }
        }
    
        return ticketsTable;
    }


    //metodo para agregar ticket
    public void AddTicked(Ticket ticket)
    {
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                string query = "INSERT INTO Ticket(NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, Id_Client, Id_Agent) VALUES (@NameTicket, @DescriptionTicket, @Priority, @Status, @Categorie, @Tag, @Id_Client, @Id_Agent)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameTicket", ticket.NameTicket);
                command.Parameters.AddWithValue("@DescriptionTicket", ticket.DescriptionTicket);
                command.Parameters.AddWithValue("@Priority", ticket.Priority);
                command.Parameters.AddWithValue("@Categorie", ticket.categorie);
                command.Parameters.AddWithValue("@Tag", ticket.tag);
                command.Parameters.AddWithValue("@Status", ticket.Status);
                command.Parameters.AddWithValue("@Id_Client", ticket.IdClient);
                command.Parameters.AddWithValue("@Id_Agent", ticket.IdAgent);
                connection.Open();

                command.ExecuteNonQuery();
            }
    }

    //metodo para actualizar ticket
    public void UpdateTicketByAdmin(Ticket ticket)
    {
       
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                string query = "UPDATE Ticket SET NameTicket = @NameTicket, DescriptionTicket = @DescriptionTicket, Priority = @Priority, Categorie = @Categorie, Tag = @Tag, Id_Agent = @Id_Agent WHERE idTicket = @IdTicket";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdTicket", ticket.IdTicket);
                command.Parameters.AddWithValue("@NameTicket", ticket.NameTicket);
                command.Parameters.AddWithValue("@DescriptionTicket", ticket.DescriptionTicket);
                command.Parameters.AddWithValue("@Priority", ticket.Priority);
                command.Parameters.AddWithValue("@Categorie", ticket.categorie);
                command.Parameters.AddWithValue("@Tag", ticket.tag);
                command.Parameters.AddWithValue("@Id_Agent", ticket.IdAgent);
                connection.Open();

                command.ExecuteNonQuery();
            }
    }

    
    public void DeleteTicket(int id)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "DELETE FROM Ticket WHERE idTicket = @IdTicket";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdTicket", id);
            connection.Open();

            command.ExecuteNonQuery();

        }
    }

}