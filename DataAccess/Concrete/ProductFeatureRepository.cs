using DataAccess.Abstract;
using DataAccess.Data;
using Entities;

namespace DataAccess.Concrete;

public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
{
    public ProductFeatureRepository(DataContext context) : base(context) { }
}