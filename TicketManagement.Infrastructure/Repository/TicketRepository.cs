using Domain.DTO.Request;
using Domain.Entities;
using Domain.Request;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
{
    private readonly AppDbContext _context;

    public TicketRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public List<Ticket> GetTickets(GetTicketsRequestDto request)
    {
        IQueryable<Ticket> query = _context.Set<Ticket>()
            .Include(t => t.Product)
            .Include(t => t.Priority)
            .Include(t => t.Category)
            .Include(t => t.User)
            .Include(t => t.Assignee);
        
        if(request == null) return query.ToList();

        if (!string.IsNullOrEmpty(request.Summary))
        {
            query = query.Where(t => (EF.Functions.Like(t.Summary, $"%{request.Summary}%")));
        }

        if (request.ProductId != null && request.ProductId.Count() > 0)
        {
            query = query.Where(t => request.ProductId.Contains(t.ProductId));
        }
        
        if (request.CategoryId != null && request.CategoryId .Count() > 0)
        {
            query = query.Where(t => request.CategoryId .Contains(t.CategoryId ));
        }
        
        if (request.PriorityId != null && request.PriorityId.Count() > 0)
        {
            query = query.Where(t => request.PriorityId.Contains(t.PriorityId));
        }
        
        if (request.CreatedBy != null && request.CreatedBy.Count() > 0)
        {
            query = query.Where(t => request.CreatedBy.Contains(t.CreatedBy));
        }
        
        if (request.Status != null && request.Status.Count() > 0)
        {
            query = query.Where(t => request.Status.Contains(t.Status));
        }
        
        return query.OrderByDescending(x => x.CreatedDate).ToList();
    }
}