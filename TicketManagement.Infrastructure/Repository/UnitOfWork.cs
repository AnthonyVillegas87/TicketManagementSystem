using System.Collections;
using Domain.Request;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private Hashtable _repositories;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        if(_repositories == null) _repositories = new Hashtable();
        
        var type = typeof(TEntity).Name;
        
        if(!_repositories.ContainsKey(typeof(TEntity)))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance  = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
            _repositories.Add(typeof(TEntity), repositoryInstance);
            
        }
        
        return (IGenericRepository<TEntity>)_repositories[typeof(TEntity)];
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> SaveEntitiesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}