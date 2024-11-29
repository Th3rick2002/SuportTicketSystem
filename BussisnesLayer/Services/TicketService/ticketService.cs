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

    public bool AddTicked(Ticket ticket, Client client)
    {
        return _ticketRepository.AddTicked(ticket, client);
    }

    public bool UpdateTicketByAdmin(Ticket ticket, Agent agent)
    {
        return _ticketRepository.UpdateTicketByAdmin(ticket, agent);
    }

    public bool DeleteTicket(Ticket ticket, Agent agent)
    {
        return _ticketRepository.DeleteTicket(ticket, agent);
    }
}