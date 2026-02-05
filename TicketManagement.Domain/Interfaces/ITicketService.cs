using Domain.DTO.Request;

namespace Domain.Interfaces;

public interface ITicketService
{
    List<GetTicketResponseDto> GetTickets(GetTicketsRequestDto request);
    GetTicketResponseDto GetTicket(int ticketId);
}