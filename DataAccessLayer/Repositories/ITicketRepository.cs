using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ITicketRepository
{
    DataTable GetTickets();
    bool AddTicked(Ticket ticket);
    bool UpdateTicketByAdmin(Ticket ticket);
    public bool DeleteTicket(Ticket ticket);
}