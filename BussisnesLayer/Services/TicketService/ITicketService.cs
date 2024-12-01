using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.TicketService;

public interface ITicketService
{
    DataTable GetTickets();
    void AddTicked(Ticket ticket);
    void UpdateTicketByAdmin(Ticket ticket);
    void DeleteTicket(int id);
    
}