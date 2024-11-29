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
            string query = "SELECT NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, Id_Client, Id_Agent FROM Ticket";
            
            using (var reader = connection.ExecuteReader(query))
            {
                ticketsTable.Load(reader);
            }
        }
    
        return ticketsTable;
    }


    //metodo para agregar ticket
    public bool AddTicked(Ticket ticket, Client client)
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
    public bool UpdateTicketByAdmin(Ticket ticket, Agent agent)
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
                    @AgentId = agent.IdAgent,
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

    
    public bool DeleteTicket(Ticket ticket, Agent agent)
    {
        try
        {
            using (var connection = (SqlConnection)_dbConnection.GetConnection())
            {
                var parameters = new
                {
                    @TicketId = ticket.IdTicket,
                    @Id_Client = ticket.IdClient,
                    @AgentId = agent.IdAgent,
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