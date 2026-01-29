using Domain.Request;

namespace Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public T GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public void AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}