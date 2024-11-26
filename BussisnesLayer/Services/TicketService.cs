using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussisnesLayer.Services
{
    public class TicketService : ITicketRepository
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository
            ?? throw new ArgumentNullException(nameof(ticketRepository));

        }

        public TicketService() { }

        public DataTable GetTicketsByClient()
        {
            return _ticketRepository.GetTicketsByClient();
        }

        public void AddTicked(Ticket ticket, Client client)
        {
            _ticketRepository.AddTicked(ticket, client);
        }

        public void AddTicked(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketByAdmin(Ticket ticket, Agent agent)
        {
            _ticketRepository.UpdateTicketByAdmin(ticket, agent);
        }

        public void DeleteTicketByAdmin(Ticket ticket, Agent agent)
        {
            _ticketRepository.DeleteTicketByAdmin(ticket, agent);
        }

        public void UpdateTicketByAdmin(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}