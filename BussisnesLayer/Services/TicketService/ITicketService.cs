using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.TicketService;

public interface ITicketService
{
    DataTable GetTickets();
    bool AddTicked(Ticket ticket);
    bool UpdateTicketByAdmin(Ticket ticket);
    public bool DeleteTicket(Ticket ticket);
    
}