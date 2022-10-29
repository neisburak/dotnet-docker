using Entities;

namespace Business.Abstract;

public interface IProductService
{
    Task<Product?> GetAsync(int id, CancellationToken cancellationToken);
    Task<List<Product>> GetAsync(CancellationToken cancellationToken);
}