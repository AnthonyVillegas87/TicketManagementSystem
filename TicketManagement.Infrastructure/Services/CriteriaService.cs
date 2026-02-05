using Domain.Entities;
using Domain.Interfaces;
using Domain.Request;

namespace Infrastructure.Services;

public class CriteriaService(IUnitOfWork unitOfWork) : ICriteriaService
{
    public List<Category> GetCategories()
    {
        return unitOfWork.Repository<Category>().GetAllAsync();
    }

    public List<Priority> GetPriorities()
    {
        return unitOfWork.Repository<Priority>().GetAllAsync();
    }

    public List<Product> GetProducts()
    {
        return unitOfWork.Repository<Product>().GetAllAsync();
    }

    public List<string> GetStatuses()
    {
        return new List<string> { "Open", "In Progress", "Resolved", "Closed" };
    }
}