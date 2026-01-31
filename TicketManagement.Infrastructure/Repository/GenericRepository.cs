using System.Data.Common;
using Domain.Request;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
       _context = context;     
    }
    public T GetByIdAsync(int id)
    {
       return _context.Set<T>().Find(id);
    }

    public List<T> GetAllAsync()
    {
        return _context.Set<T>().ToList();
    }

    public void AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void UpdateAsync(T entity)
    {
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void DeleteAsync(T entity)
    {
       _context.Set<T>().Remove(entity);
    }

    public void SaveChangesAsync()
    {
        _context.SaveChanges();
    }
}