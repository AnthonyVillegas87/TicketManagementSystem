using Domain.DTO.Request;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Request;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    List<Ticket> GetTickets(GetTicketsRequestDto request);
}