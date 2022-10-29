using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public Task<Category?> GetAsync(int id, CancellationToken cancellationToken)
    {
        return _categoryRepository.GetAsync(id, cancellationToken);
    }

    public Task<List<Category>> GetAsync(CancellationToken cancellationToken)
    {
        return _categoryRepository.GetWhereAsync((x) => true, cancellationToken);
    }
}