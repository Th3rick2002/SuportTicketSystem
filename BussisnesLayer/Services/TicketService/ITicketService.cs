using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.TicketService;

public interface ITicketService
{
    public DataTable GetTicketsByClient();
    public void AddTicked(Ticket ticket, Client client);
    public void UpdateTicketByAdmin(Ticket ticket, Agent agent);
    
}