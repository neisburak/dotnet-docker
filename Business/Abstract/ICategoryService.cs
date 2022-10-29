using Entities;

namespace Business.Abstract;

public interface ICategoryService
{
    Task<Category?> GetAsync(int id, CancellationToken cancellationToken);
    Task<List<Category>> GetAsync(CancellationToken cancellationToken);
}