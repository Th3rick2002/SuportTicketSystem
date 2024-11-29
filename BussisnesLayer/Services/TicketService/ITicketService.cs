using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.TicketService;

public interface ITicketService
{
    DataTable GetTickets();
    bool AddTicked(Ticket ticket, Client client);
    bool UpdateTicketByAdmin(Ticket ticket, Agent agent);
    public bool DeleteTicket(Ticket ticket, Agent agent);
    
}