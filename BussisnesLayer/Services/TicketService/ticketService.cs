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

    public bool AddTicked(Ticket ticket)
    {
        return _ticketRepository.AddTicked(ticket);
    }

    public bool UpdateTicketByAdmin(Ticket ticket)
    {
        return _ticketRepository.UpdateTicketByAdmin(ticket);
    }

    public bool DeleteTicket(Ticket ticket)
    {
        return _ticketRepository.DeleteTicket(ticket);
    }
}