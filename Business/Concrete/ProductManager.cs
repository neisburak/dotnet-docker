using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IProductFeatureRepository _productFeatureRepository;

    public ProductManager(IProductRepository productRepository, IProductFeatureRepository productFeatureRepository)
    {
        _productRepository = productRepository;
        _productFeatureRepository = productFeatureRepository;
    }

    public Task<Product?> GetAsync(int id, CancellationToken cancellationToken)
    {
        return _productRepository.GetAsync(id, cancellationToken);
    }

    public Task<List<Product>> GetAsync(CancellationToken cancellationToken)
    {
        return _productRepository.GetWhereAsync((x) => true, cancellationToken);
    }
}