namespace Domain.Request;

public interface IGenericRepository<T> where T : class
{
    T GetByIdAsync(int id);
    List<T> GetAllAsync();
    void AddAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);
    void SaveChangesAsync();
}