namespace Domain.Request;

public interface IUnitOfWork : IDisposable
{
    ITicketRepository TicketRepository { get; }
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    
    Task<int> SaveChangesAsync();
    Task<bool> SaveEntitiesAsync();
}