using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT ticket.IdTicket, ticket.NameTicket, ticket.DescriptionTicket, ticket.Priority, ticket.Status, Categories.NameCategorie AS Categorie, Tag.NameTag AS Tag,Client.FirstName + ' ' + Client.LastName AS Client ,COALESCE(Agent.FirstName + ' ' + Agent.LastName, 'Sin asignar') AS Agent FROM Ticket INNER JOIN Categories ON ticket.Categorie = Categories.Id INNER JOIN Tag ON ticket.Tag = Tag.Id INNER JOIN Client ON ticket.Id_Client = Client.Id LEFT JOIN Agent ON ticket.Id_Agent = Agent.Id";
            
            using (var reader = connection.ExecuteReader(query))
            {
                ticketsTable.Load(reader);
            }
        }
    
        return ticketsTable;
    }


    //metodo para agregar ticket
    public bool AddTicked(Ticket ticket)
    {
        try
        {
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                var parameters = new
                {
                    @NameTicket = ticket.NameTicket,
                    @DescriptionTicket = ticket.DescriptionTicket,
                    @Priority = ticket.Priority,
                    @Status = ticket.Status,
                    @Categorie = ticket.categorie,
                    @Tag = ticket.tag,
                    @Id_Client = ticket.IdClient,
                    @AgentId = ticket.IdAgent,
                    @Details = "Creación del Ticket"
                };
            
                var result = connection.Execute("sp_InsertarTicketYLog", parameters, commandType: CommandType.StoredProcedure);

                return result == 1;
            }
        }
        catch (Exception e)
        {
            return false;
        }
        
    }

    //metodo para actualizar ticket
    public bool UpdateTicketByAdmin(Ticket ticket)
    {
        try
        {
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                var parameters = new
                {
                    @TicketId = ticket.IdTicket,
                    @NameTicket = ticket.NameTicket,
                    @DescriptionTicket = ticket.DescriptionTicket,
                    @Priority = ticket.Priority,
                    @Status = ticket.Status,
                    @Categorie = ticket.categorie,
                    @Tag = ticket.tag,
                    @Id_Client = ticket.IdClient,
                    @AgentId = ticket.IdAgent,
                    @Details = "Actualización del ticket"
                };
                
                connection.Execute("sp_ActualizarTicketYLog", parameters, commandType: CommandType.StoredProcedure);
                
                return true;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    
    public bool DeleteTicket(Ticket ticket)
    {
        try
        {
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                var parameters = new
                {
                    @TicketId = ticket.IdTicket,
                    @Id_Client = ticket.IdClient,
                    @AgentId = ticket.IdAgent,
                    @Details = "Eliminación del ticket"
                };
                var result = connection.Execute("sp_EliminarTicketYLog", parameters, commandType: CommandType.StoredProcedure);
                
                return result == 1;
            }
        }
        catch (Exception e)
        {
            return false;
        }
    }

}