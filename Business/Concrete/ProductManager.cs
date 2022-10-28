using Business.Abstract;
using DataAccess.Abstract;

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
}