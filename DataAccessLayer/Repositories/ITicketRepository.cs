using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ITicketRepository
{
    DataTable GetTickets();
    bool AddTicked(Ticket ticket, Client client);
    bool UpdateTicketByAdmin(Ticket ticket, Agent agent);
    public bool DeleteTicket(Ticket ticket, Agent agent);
}