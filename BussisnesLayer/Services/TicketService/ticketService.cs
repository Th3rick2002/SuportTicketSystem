using System.Data;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services.TicketService;

public class ticketService: ITicketService
{
    private readonly TicketRepository _ticketRepository;

    public ticketService()
    {
        _ticketRepository = new TicketRepository();
    }

    public DataTable GetTickets()
    {
        return _ticketRepository.GetTickets();
    }

    public void AddTicked(Ticket ticket)
    {
        _ticketRepository.AddTicked(ticket);
    }

    public void UpdateTicketByAdmin(Ticket ticket)
    {
        _ticketRepository.UpdateTicketByAdmin(ticket);
    }

    public void DeleteTicket(int id)
    {
        _ticketRepository.DeleteTicket(id);
    }
}