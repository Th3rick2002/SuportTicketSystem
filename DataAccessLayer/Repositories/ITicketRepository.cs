using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ITicketRepository
{
    DataTable GetTicketsByClient();
    void AddTicked(Ticket ticket, Client client);
    void UpdateTicketByAdmin(Ticket ticket, Agent agent);
    void DeleteTicketByAdmin(Ticket ticket, Agent agent);
}