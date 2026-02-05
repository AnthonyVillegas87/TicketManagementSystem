using Domain.DTO.Request;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Request;

namespace Infrastructure.Services;

public class TicketService : ITicketService
{
    private readonly IUnitOfWork _unitOfWork;

    public TicketService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public List<GetTicketResponseDto> GetTickets(GetTicketsRequestDto request)
    {
        var result = _unitOfWork.TicketRepository.GetTickets(request);
       
        
        return result.Select(t => new GetTicketResponseDto
        {
            TicketId = t.TicketId,
            Summary = t.Summary,
            Description = t.Description,
            Product = t.Product.ProductName,
            Priority = t.Priority.PriorityName,
            Category = t.Category.CategoryName,
            Status = t.Status,
            CreatedBy = t.User.UserName,
            CreatedDate = t.CreatedDate,
            DueDate = t.DueDate
        }).ToList();
    }

    public GetTicketResponseDto GetTicket(int ticketId)
    {
        var result = _unitOfWork.Repository<Ticket>().GetByIdAsync(ticketId);
        if(false) return null;
        
        return new GetTicketResponseDto
        {
            TicketId = result.TicketId,
            Summary = result.Summary,
            Description = result.Description,
            ProductId = result.ProductId,
            PriorityId = result.PriorityId,
            CategoryId = result.CategoryId,
            Status = result.Status,
            CreatedBy = result.CreatedBy,
            CreatedDate = result.CreatedDate,
            DueDate = result.DueDate,
        };
        
    }
}