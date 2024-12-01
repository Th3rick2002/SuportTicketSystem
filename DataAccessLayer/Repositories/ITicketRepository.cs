using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ITicketRepository
{
    DataTable GetTickets();
    void AddTicked(Ticket ticket);
    void UpdateTicketByAdmin(Ticket ticket);
    public void DeleteTicket(int id);
}