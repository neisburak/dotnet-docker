using DataAccess.Abstract;
using DataAccess.Data;
using Entities;

namespace DataAccess.Concrete;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(DataContext context) : base(context) { }
}