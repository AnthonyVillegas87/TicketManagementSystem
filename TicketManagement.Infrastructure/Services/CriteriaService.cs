using Domain.Entities;
using Domain.Interfaces;
using Domain.Request;

namespace Infrastructure.Services;

public class CriteriaService : ICriteriaService
{
    private readonly IUnitOfWork _unitOfWork;

    public CriteriaService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    
    public List<Category> GetCategories()
    {
        return _unitOfWork.Repository<Category>().GetAllAsync();
    }

    public List<Priority> GetPriorities()
    {
        return _unitOfWork.Repository<Priority>().GetAllAsync();
    }

    public List<Product> GetProducts()
    {
        return _unitOfWork.Repository<Product>().GetAllAsync();
    }

    public List<string> GetStatuses()
    {
        return new List<string> { "Open", "In Progress", "Resolved", "Closed" };
    }
}